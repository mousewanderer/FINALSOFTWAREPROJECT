using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.Data;
using System.Data.SqlClient;


namespace SOFTDEV_FINAL_PROJECT
{
    public partial class RANKING : Form
    {
        public RANKING()
        {
            InitializeComponent();
        }

        string connectionString = "Server=localhost;Database=Final_projectDB;Trusted_Connection=True;";
        private void RANKING_Load(object sender, EventArgs e)
        {
            LoadRankings();
        }


private void LoadRankings()
    {

            string queryMath = @"
WITH Ranked AS (
  SELECT 
    S.FirstName + ' ' + S.LastName AS FullName,
    (Q.Math1 + Q.Math2) AS MathScore,
    DENSE_RANK() OVER (ORDER BY (Q.Math1 + Q.Math2) DESC) AS RankNumber
  FROM Students S
  JOIN Quizzes Q ON S.StudentID = Q.StudentID
)
SELECT TOP 10
  CASE 
    WHEN RankNumber = 1 THEN '1st'
    WHEN RankNumber = 2 THEN '2nd'
    WHEN RankNumber = 3 THEN '3rd'
    ELSE CAST(RankNumber AS VARCHAR)
  END AS Rank,
  FullName,
  MathScore
FROM Ranked;";



            string queryOverall = @"
WITH Ranked AS (
  SELECT 
    S.FirstName + ' ' + S.LastName AS FullName,
    (Q.Math1 + Q.Math2 + Q.InfoTech1 + Q.InfoTech2 + Q.Biology1 + Q.Physics1) AS TotalScore,
    DENSE_RANK() OVER (ORDER BY (Q.Math1 + Q.Math2 + Q.InfoTech1 + Q.InfoTech2 + Q.Biology1 + Q.Physics1) DESC) AS RankNumber
  FROM Students S
  JOIN Quizzes Q ON S.StudentID = Q.StudentID
)
SELECT TOP 10
  CASE 
    WHEN RankNumber = 1 THEN '1st'
    WHEN RankNumber = 2 THEN '2nd'
    WHEN RankNumber = 3 THEN '3rd'
    ELSE CAST(RankNumber AS VARCHAR)
  END AS Rank,
  FullName,
  TotalScore
FROM Ranked;
";




            using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();

                // Load Math Grid
                using (SqlDataAdapter adapterMath = new SqlDataAdapter(queryMath, conn))
                {
                    DataTable dtMath = new DataTable();
                    adapterMath.Fill(dtMath);

                    listViewMath.Clear();
                    listViewMath.View = View.Details;
                    listViewMath.Columns.Add("Rank", 70);
                    listViewMath.Columns.Add("Name", 150);
                    listViewMath.Columns.Add("Math Score", 100);

                    listViewMath.Clear();
                    listViewMath.View = View.Details;
                    listViewMath.Columns.Add("Rank", 70);
                    listViewMath.Columns.Add("Name", 150);
                    listViewMath.Columns.Add("Math Score", 100);

                    foreach (DataRow row in dtMath.Rows)
                    {
                        string rank = row["Rank"].ToString();
                        string name = row["FullName"].ToString();
                        string score = row["MathScore"].ToString();

                        ListViewItem item = new ListViewItem(rank);
                        item.SubItems.Add(name);
                        item.SubItems.Add(score);

                        // Color-code top 3 ranks
                        switch (rank)
                        {
                            case "1st":
                                item.BackColor = Color.Gold;
                                item.ForeColor = Color.Black;
                                break;
                            case "2nd":
                                item.BackColor = Color.Silver;
                                item.ForeColor = Color.Black;
                                break;
                            case "3rd":
                                item.BackColor = Color.SandyBrown;
                                item.ForeColor = Color.Black;
                                break;
                        }

                        listViewMath.Items.Add(item);
                    }



       
                }



                // Load Overall Grid
                using (SqlDataAdapter adapterOverall = new SqlDataAdapter(queryOverall, conn))
                {
                    DataTable dtOverall = new DataTable();
                    adapterOverall.Fill(dtOverall);

                    listViewOverall.Clear();
                    listViewOverall.View = View.Details;
                    listViewOverall.Columns.Add("Rank", 70);
                    listViewOverall.Columns.Add("Name", 150);
                    listViewOverall.Columns.Add("Total Score", 100);

                    foreach (DataRow row in dtOverall.Rows)
                    {
                        string rank = row["Rank"].ToString();
                        string name = row["FullName"].ToString();
                        string score = row["TotalScore"].ToString();

                        ListViewItem item = new ListViewItem(rank);
                        item.SubItems.Add(name);
                        item.SubItems.Add(score);

                        // Color-code top 3 ranks
                        switch (rank)
                        {
                            case "1st":
                                item.BackColor = Color.Gold;
                                item.ForeColor = Color.Black;
                                break;
                            case "2nd":
                                item.BackColor = Color.Silver;
                                item.ForeColor = Color.Black;
                                break;
                            case "3rd":
                                item.BackColor = Color.SandyBrown;
                                item.ForeColor = Color.Black;
                                break;
                        }

                        listViewOverall.Items.Add(item);
                    }

                }

                }
            }

}
}
