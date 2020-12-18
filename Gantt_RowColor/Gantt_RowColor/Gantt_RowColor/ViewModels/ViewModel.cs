using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Collections.Specialized;
using System.Text;
using Syncfusion.Windows.Controls.Gantt;

namespace Gantt_RowColor
{
    public class ViewModel
    {
        private int id = 0;

        private DateTime date = DateTime.Today;

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewModel"/> class.
        /// </summary>
        public ViewModel()
        {
            _taskDetails = this.GetData();
        }

        private ObservableCollection<Task> _taskDetails;

        /// <summary>
        /// Gets or sets the appointment item source.
        /// </summary>
        /// <value>The appointment item source.</value>
        public ObservableCollection<Task> TaskDetails
        {
            get
            {
                return _taskDetails;
            }
            set
            {
                _taskDetails = value;
            }
        }

        private List<Mode> _validationMode;

        public List<Mode> ValidationMode
        {
            get
            {
                return _validationMode;
            }
            set
            {
                _validationMode = value;
            }
        }

        /// <summary>
        /// Gets the data.
        /// </summary>
        /// <returns></returns>
        public ObservableCollection<Task> GetData()
        {
            var data = new ObservableCollection<Task>();
            data.Add(new Task { Id = this.id++, RowType = RowType.Projectrow, Name = "Project Row", StDate = this.date, EndDate = this.date.AddDays(2) });
            data[0].ChildTask.Add(new Task { Id = this.id++, RowType = RowType.SubProjectRow, Name = "Sub Project Row", StDate = this.date, EndDate = this.date.AddDays(2) });
            data[0].ChildTask[0].ChildTask.Add(new Task { Id = this.id++, RowType = RowType.AnalysisRow, Name = "Analysis Row", StDate = this.date, EndDate = this.date.AddDays(2) });
            data[0].ChildTask[0].ChildTask[0].ChildTask.Add(new Task { Id = this.id++, RowType = RowType.ProductionRow, Name = "Production Row", StDate = this.date, EndDate = this.date.AddDays(2) });
           
            data[0].ChildTask[0].ChildTask.Add(new Task { Id = this.id++, RowType = RowType.AnalysisRow, Name = "Analysis Row", StDate = this.date, EndDate = this.date.AddDays(2) });
            data[0].ChildTask[0].ChildTask[1].ChildTask.Add(new Task { Id = this.id++, RowType = RowType.ProductionRow, Name = "Production Row", StDate = this.date, EndDate = this.date.AddDays(2) });
            data[0].ChildTask[0].ChildTask[1].ChildTask[0].ChildTask.Add(new Task { Id = this.id++, RowType = RowType.TaskRow, Name = "Task Row", StDate = this.date, EndDate = this.date.AddDays(2) });

            return data;
        }
    }

}