using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data;

namespace FileUpload
{
    public partial class Grid : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                FileUpload1.PostedFile.SaveAs(Server.MapPath("~/Data/") + FileUpload1.FileName);
            }

            DataTable dt = new DataTable();
            dt.Columns.Add("File", typeof(string));
            dt.Columns.Add("Size", typeof(string));
            dt.Columns.Add("Type", typeof(string));

            foreach (string strFile in Directory.GetFiles(Server.MapPath("~/Data")))
            {
                FileInfo file = new FileInfo(strFile);

                dt.Rows.Add(file.Name, file.Length, GetFileTypeByExtension(file.Extension));
            }
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

            private string GetFileTypeByExtension(string extension)
            {
                switch(extension.ToLower())
                {
                    case ".doc":
                    case ".docx":
                        return "Microsoft Word Document";
                    case ".xlsx":
                    case ".xls":
                        return "Microsoft Excel Document";
                    case ".txt":
                        return "Text Document";
                    case ".jpg":
                    case ".png":
                        return "Image";
                    default:
                        return "Unknown";
                }
            }
        }
    }
