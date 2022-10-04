using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NameListWebApp
{
    
    public partial class MainUI : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected void saveButton_Click(object sender, EventArgs e)
        {

            List<string> nameList;
            string name = nameTextBox.Text;

            if (ViewState["Names"] == null)
            {
                nameList = new List<string>();
            }
            else
            {
                nameList = (List<string>)ViewState["Names"];
            }
            nameList.Add(name);
            nameTextBox.Text = null;
            ViewState["Names"] = nameList;
        }
        protected void showAllButton_Click(object sender, EventArgs e)
        {
            List<string> showNameList = (List<string>)ViewState["Names"];
            for (int i = 0; i < showNameList.Count; i++)
            {
                nameListBox.Items.Add(showNameList[i]);   
            }
            totalNumberLabel.Text = showNameList.Count.ToString();
        }
    }
}