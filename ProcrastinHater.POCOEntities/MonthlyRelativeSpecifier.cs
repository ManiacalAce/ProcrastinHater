//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace ProcrastinHater.POCOEntities
{
    public partial class MonthlyRelativeSpecifier
    {
        #region Primitive Properties
    
        public virtual int MonthlyRelativeScheduleID
        {
            get { return _monthlyRelativeScheduleID; }
            set
            {
                if (_monthlyRelativeScheduleID != value)
                {
                    if (SchedulingInformation != null && SchedulingInformation.ScheduleID != value)
                    {
                        SchedulingInformation = null;
                    }
                    _monthlyRelativeScheduleID = value;
                }
            }
        }
        private int _monthlyRelativeScheduleID;
    
        public virtual int DayType
        {
            get;
            set;
        }
    
        public virtual int Frequency
        {
            get;
            set;
        }
    
        public virtual long TimeOfDayToStartTicks
        {
            get;
            set;
        }

        #endregion
        #region Navigation Properties
    
        public virtual SchedulingInformation SchedulingInformation
        {
            get { return _schedulingInformation; }
            set
            {
                if (!ReferenceEquals(_schedulingInformation, value))
                {
                    var previousValue = _schedulingInformation;
                    _schedulingInformation = value;
                    FixupSchedulingInformation(previousValue);
                }
            }
        }
        private SchedulingInformation _schedulingInformation;

        #endregion
        #region Association Fixup
    
        private void FixupSchedulingInformation(SchedulingInformation previousValue)
        {
            if (previousValue != null && previousValue.MonthlyRelativeSpecifiers.Contains(this))
            {
                previousValue.MonthlyRelativeSpecifiers.Remove(this);
            }
    
            if (SchedulingInformation != null)
            {
                if (!SchedulingInformation.MonthlyRelativeSpecifiers.Contains(this))
                {
                    SchedulingInformation.MonthlyRelativeSpecifiers.Add(this);
                }
                if (MonthlyRelativeScheduleID != SchedulingInformation.ScheduleID)
                {
                    MonthlyRelativeScheduleID = SchedulingInformation.ScheduleID;
                }
            }
        }

        #endregion
    }
}
