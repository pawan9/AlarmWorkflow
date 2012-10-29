﻿using System.Windows.Controls;
using AlarmWorkflow.Windows.ConfigurationContracts;

namespace AlarmWorkflow.Windows.Configuration.TypeEditors
{
    /// <summary>
    /// Interaction logic for Int32TypeEditor.xaml
    /// </summary>
    public partial class Int32TypeEditor : UserControl, ITypeEditor
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Int32TypeEditor"/> class.
        /// </summary>
        public Int32TypeEditor()
        {
            InitializeComponent();

            this.DataContext = this;
        }

        #endregion

        #region ITypeEditor Members

        /// <summary>
        /// Gets/sets the value that is edited.
        /// </summary>
        public object Value { get; set; }

        /// <summary>
        /// Gets the visual element that is editing the value.
        /// </summary>
        public System.Windows.UIElement Visual
        {
            get { return this; }
        }

        #endregion
    }
}
