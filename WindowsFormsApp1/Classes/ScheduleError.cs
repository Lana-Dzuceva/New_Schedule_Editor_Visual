using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Classes
{
    public enum ErrorTypes
    {
        lector,
        audience
    }

    
    public class ScheduleError
    {
        public ErrorTypes errorType;
        public string sameInfo;
        public List<DataGridViewCell> cellsWithSameInfo;

        public ScheduleError(ErrorTypes errorType, string text, List<DataGridViewCell> cells)
        {
            this.errorType = errorType;
            sameInfo = text;
            cellsWithSameInfo = new List<DataGridViewCell>();
            cellsWithSameInfo = cells.ToList();
            MessageBox.Show(cellsWithSameInfo.GetHashCode() + " " + cells.GetHashCode());
        }
    }
}
