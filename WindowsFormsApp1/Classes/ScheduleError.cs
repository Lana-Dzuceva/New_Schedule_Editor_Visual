using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Editor.Classes
{
    public enum ErrorTypes
    {
        lector,
        audience
    }
    
    public class BadCell 
    {
        public string subject;
        public string audience;
        public DataGridViewCell cell;
        public BadCell(string subject, string audience, DataGridViewCell cell)
        {
            this.subject = subject;
            this.audience = audience;
            this.cell = cell;
        }
    }
    public class ScheduleError
    {
        public ErrorTypes errorType;
        public string sameInfo;
        public List<BadCell> cellsWithSameInfo;

        public ScheduleError(ErrorTypes errorType, string text, List<BadCell> cells)
        {
            this.errorType = errorType;
            sameInfo = text;
            cellsWithSameInfo = new List<BadCell>();
            cellsWithSameInfo = cells.ToList();
        }
    }
}
