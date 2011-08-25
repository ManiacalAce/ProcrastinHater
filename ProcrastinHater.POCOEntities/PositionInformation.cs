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
    public partial class PositionInformation
    {
        #region Primitive Properties
    
        public virtual int ItemID
        {
            get { return _itemID; }
            set
            {
                try
                {
                    _settingFK = true;
                    if (_itemID != value)
                    {
                        if (ChecklistElement != null && ChecklistElement.ItemID != value)
                        {
                            ChecklistElement = null;
                        }
                        _itemID = value;
                    }
                }
                finally
                {
                    _settingFK = false;
                }
            }
        }
        private int _itemID;
    
        public virtual Nullable<int> NextItemID
        {
            get { return _nextItemID; }
            set
            {
                try
                {
                    _settingFK = true;
                    if (_nextItemID != value)
                    {
                        if (NextItem != null && NextItem.ItemID != value)
                        {
                            NextItem = null;
                        }
                        _nextItemID = value;
                    }
                }
                finally
                {
                    _settingFK = false;
                }
            }
        }
        private Nullable<int> _nextItemID;
    
        public virtual Nullable<int> PreviousItemID
        {
            get { return _previousItemID; }
            set
            {
                try
                {
                    _settingFK = true;
                    if (_previousItemID != value)
                    {
                        if (PreviousItem != null && PreviousItem.ItemID != value)
                        {
                            PreviousItem = null;
                        }
                        _previousItemID = value;
                    }
                }
                finally
                {
                    _settingFK = false;
                }
            }
        }
        private Nullable<int> _previousItemID;

        #endregion
        #region Navigation Properties
    
        public virtual ChecklistElement ChecklistElement
        {
            get { return _checklistElement; }
            set
            {
                if (!ReferenceEquals(_checklistElement, value))
                {
                    var previousValue = _checklistElement;
                    _checklistElement = value;
                    FixupChecklistElement(previousValue);
                }
            }
        }
        private ChecklistElement _checklistElement;
    
        public virtual ChecklistElement NextItem
        {
            get { return _nextItem; }
            set
            {
                if (!ReferenceEquals(_nextItem, value))
                {
                    var previousValue = _nextItem;
                    _nextItem = value;
                    FixupNextItem(previousValue);
                }
            }
        }
        private ChecklistElement _nextItem;
    
        public virtual ChecklistElement PreviousItem
        {
            get { return _previousItem; }
            set
            {
                if (!ReferenceEquals(_previousItem, value))
                {
                    var previousValue = _previousItem;
                    _previousItem = value;
                    FixupPreviousItem(previousValue);
                }
            }
        }
        private ChecklistElement _previousItem;

        #endregion
        #region Association Fixup
    
        private bool _settingFK = false;
    
        private void FixupChecklistElement(ChecklistElement previousValue)
        {
            if (previousValue != null && ReferenceEquals(previousValue.PositionInformation, this))
            {
                previousValue.PositionInformation = null;
            }
    
            if (ChecklistElement != null)
            {
                ChecklistElement.PositionInformation = this;
                if (ItemID != ChecklistElement.ItemID)
                {
                    ItemID = ChecklistElement.ItemID;
                }
            }
        }
    
        private void FixupNextItem(ChecklistElement previousValue)
        {
            if (previousValue != null && previousValue.PositionsNextItemsSet.Contains(this))
            {
                previousValue.PositionsNextItemsSet.Remove(this);
            }
    
            if (NextItem != null)
            {
                if (!NextItem.PositionsNextItemsSet.Contains(this))
                {
                    NextItem.PositionsNextItemsSet.Add(this);
                }
                if (NextItemID != NextItem.ItemID)
                {
                    NextItemID = NextItem.ItemID;
                }
            }
            else if (!_settingFK)
            {
                NextItemID = null;
            }
        }
    
        private void FixupPreviousItem(ChecklistElement previousValue)
        {
            if (previousValue != null && previousValue.PositionsPreviousItemsSet.Contains(this))
            {
                previousValue.PositionsPreviousItemsSet.Remove(this);
            }
    
            if (PreviousItem != null)
            {
                if (!PreviousItem.PositionsPreviousItemsSet.Contains(this))
                {
                    PreviousItem.PositionsPreviousItemsSet.Add(this);
                }
                if (PreviousItemID != PreviousItem.ItemID)
                {
                    PreviousItemID = PreviousItem.ItemID;
                }
            }
            else if (!_settingFK)
            {
                PreviousItemID = null;
            }
        }

        #endregion
    }
}
