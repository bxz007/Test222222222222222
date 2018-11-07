using GameFramework.DataTable;
using System.Collections.Generic;

namespace GameMain
{
    /// <summary>
    /// 用户表
    /// </summary>
    public class DRUser : IDataRow
    {
        /// <summary>
        /// 实体编号。
        /// </summary>
        public int Id
        {
            get;
            private set;
        }
       

        public string Description
        {
            get;
            private set;
        }
        public void ParseDataRow(string dataRowText)
        {
            string[] text = DataTableExtension.SplitDataRow(dataRowText);
            int index = 0;
            index++;
            Id = int.Parse(text[index++]);
            index++;          
            Description = text[index++];
        }

        private void AvoidJIT()
        {
            new Dictionary<int, DRUser>();
        }
    }
}
