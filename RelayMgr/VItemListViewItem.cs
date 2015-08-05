using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
namespace RelayMgr
{
   public class VItemListViewItem : ListViewItem
    {
       /// 标题
       /// </summary>
       public string Title=string.Empty;
       public List<string> CommandList = new List<string>();
       public string Interface = string.Empty;
    }
   public class CommandItem
   {
       public string ID;
       public string Command;
   }
}
