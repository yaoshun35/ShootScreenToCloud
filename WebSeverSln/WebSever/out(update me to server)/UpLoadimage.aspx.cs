using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class UpLoadImage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        HttpPostedFile hfc = Request.Files["post"];
        //暂时理解为提供了一个服务器与客户端通信的接口

        try
        {

            if (hfc != null)
            {
                string imageName = DateTime.Now.ToString("yyyymmddhhmmss") + ".jpg";
                //给上传来的图片文件定义文件名

                hfc.SaveAs(HttpContext.Current.Request.MapPath("Image") + "/" + imageName);
                //把上传来的服务器以imageName来命名并且储存在网站根目录的Image文件夹中

                Response.Write("http://94.191.71.77/Image/" + imageName);
                //向客户端返回图片在服务器中的地址。

            }

        }
        catch (Exception S)
        {

            Console.WriteLine(S.Message);


        }
    }
}