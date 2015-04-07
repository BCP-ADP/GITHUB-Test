<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class EmployeeDetails
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim TitleLabel As System.Windows.Forms.Label
        Dim First_NameLabel As System.Windows.Forms.Label
        Dim Last_NameLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim PhoneLabel As System.Windows.Forms.Label
        Dim Birth_DateLabel As System.Windows.Forms.Label
        Dim AddressLine1Label As System.Windows.Forms.Label
        Dim CityLabel As System.Windows.Forms.Label
        Dim Postal_CodeLabel As System.Windows.Forms.Label
        Dim StateLabel As System.Windows.Forms.Label
        Dim CountryLabel As System.Windows.Forms.Label
        Dim Job_TitleLabel As System.Windows.Forms.Label
        Dim DepartmentLabel As System.Windows.Forms.Label
        Dim Department_GroupLabel As System.Windows.Forms.Label
        Dim Hire_DateLabel As System.Windows.Forms.Label
        Dim ShiftLabel As System.Windows.Forms.Label
        Dim Sick_LeaveLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EmployeeDetails))
        Me.employeeDetailsTabControl = New System.Windows.Forms.TabControl
        Me.employeeInfoTabPage = New System.Windows.Forms.TabPage
        Me.Birth_DateDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.VEmployeeDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeeDetailsDataSet = New AWEViewerVB.EmployeeDetailsDataSet
        Me.PhoneTextBox = New System.Windows.Forms.TextBox
        Me.EmailTextBox = New System.Windows.Forms.TextBox
        Me.Last_NameTextBox = New System.Windows.Forms.TextBox
        Me.First_NameTextBox = New System.Windows.Forms.TextBox
        Me.TitleTextBox = New System.Windows.Forms.TextBox
        Me.addressTabPage = New System.Windows.Forms.TabPage
        Me.CountryTextBox = New System.Windows.Forms.TextBox
        Me.StateTextBox = New System.Windows.Forms.TextBox
        Me.Postal_CodeTextBox = New System.Windows.Forms.TextBox
        Me.CityTextBox = New System.Windows.Forms.TextBox
        Me.AddressLine1TextBox = New System.Windows.Forms.TextBox
        Me.employmentTabPage = New System.Windows.Forms.TabPage
        Me.Sick_LeaveTextBox = New System.Windows.Forms.TextBox
        Me.ShiftTextBox = New System.Windows.Forms.TextBox
        Me.Hire_DateDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.Department_GroupTextBox = New System.Windows.Forms.TextBox
        Me.DepartmentTextBox = New System.Windows.Forms.TextBox
        Me.Job_TitleTextBox = New System.Windows.Forms.TextBox
        Me.VEmployeeDetailsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.bindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.bindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.bindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.bindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.bindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.bindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.bindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.bindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.bindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.closeToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.VEmployeeDetailsTableAdapter = New AWEViewerVB.EmployeeDetailsDataSetTableAdapters.vEmployeeDetailsTableAdapter
        TitleLabel = New System.Windows.Forms.Label
        First_NameLabel = New System.Windows.Forms.Label
        Last_NameLabel = New System.Windows.Forms.Label
        EmailLabel = New System.Windows.Forms.Label
        PhoneLabel = New System.Windows.Forms.Label
        Birth_DateLabel = New System.Windows.Forms.Label
        AddressLine1Label = New System.Windows.Forms.Label
        CityLabel = New System.Windows.Forms.Label
        Postal_CodeLabel = New System.Windows.Forms.Label
        StateLabel = New System.Windows.Forms.Label
        CountryLabel = New System.Windows.Forms.Label
        Job_TitleLabel = New System.Windows.Forms.Label
        DepartmentLabel = New System.Windows.Forms.Label
        Department_GroupLabel = New System.Windows.Forms.Label
        Hire_DateLabel = New System.Windows.Forms.Label
        ShiftLabel = New System.Windows.Forms.Label
        Sick_LeaveLabel = New System.Windows.Forms.Label
        Me.employeeDetailsTabControl.SuspendLayout()
        Me.employeeInfoTabPage.SuspendLayout()
        CType(Me.VEmployeeDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeDetailsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.addressTabPage.SuspendLayout()
        Me.employmentTabPage.SuspendLayout()
        CType(Me.VEmployeeDetailsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.VEmployeeDetailsBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'TitleLabel
        '
        TitleLabel.AutoSize = True
        TitleLabel.Location = New System.Drawing.Point(104, 28)
        TitleLabel.Name = "TitleLabel"
        TitleLabel.Size = New System.Drawing.Size(26, 13)
        TitleLabel.TabIndex = 0
        TitleLabel.Text = "Title:"
        '
        'First_NameLabel
        '
        First_NameLabel.AutoSize = True
        First_NameLabel.Location = New System.Drawing.Point(74, 71)
        First_NameLabel.Name = "First_NameLabel"
        First_NameLabel.Size = New System.Drawing.Size(56, 13)
        First_NameLabel.TabIndex = 2
        First_NameLabel.Text = "First Name:"
        '
        'Last_NameLabel
        '
        Last_NameLabel.AutoSize = True
        Last_NameLabel.Location = New System.Drawing.Point(73, 114)
        Last_NameLabel.Name = "Last_NameLabel"
        Last_NameLabel.Size = New System.Drawing.Size(57, 13)
        Last_NameLabel.TabIndex = 4
        Last_NameLabel.Text = "Last Name:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(99, 157)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(31, 13)
        EmailLabel.TabIndex = 6
        EmailLabel.Text = "Email:"
        '
        'PhoneLabel
        '
        PhoneLabel.AutoSize = True
        PhoneLabel.Location = New System.Drawing.Point(93, 200)
        PhoneLabel.Name = "PhoneLabel"
        PhoneLabel.Size = New System.Drawing.Size(37, 13)
        PhoneLabel.TabIndex = 8
        PhoneLabel.Text = "Phone:"
        '
        'Birth_DateLabel
        '
        Birth_DateLabel.AutoSize = True
        Birth_DateLabel.Location = New System.Drawing.Point(77, 244)
        Birth_DateLabel.Name = "Birth_DateLabel"
        Birth_DateLabel.Size = New System.Drawing.Size(53, 13)
        Birth_DateLabel.TabIndex = 10
        Birth_DateLabel.Text = "Birth Date:"
        '
        'AddressLine1Label
        '
        AddressLine1Label.AutoSize = True
        AddressLine1Label.Location = New System.Drawing.Point(63, 42)
        AddressLine1Label.Name = "AddressLine1Label"
        AddressLine1Label.Size = New System.Drawing.Size(73, 13)
        AddressLine1Label.TabIndex = 0
        AddressLine1Label.Text = "Address Line1:"
        '
        'CityLabel
        '
        CityLabel.AutoSize = True
        CityLabel.Location = New System.Drawing.Point(113, 91)
        CityLabel.Name = "CityLabel"
        CityLabel.Size = New System.Drawing.Size(23, 13)
        CityLabel.TabIndex = 2
        CityLabel.Text = "City:"
        '
        'Postal_CodeLabel
        '
        Postal_CodeLabel.AutoSize = True
        Postal_CodeLabel.Location = New System.Drawing.Point(73, 140)
        Postal_CodeLabel.Name = "Postal_CodeLabel"
        Postal_CodeLabel.Size = New System.Drawing.Size(63, 13)
        Postal_CodeLabel.TabIndex = 4
        Postal_CodeLabel.Text = "Postal Code:"
        '
        'StateLabel
        '
        StateLabel.AutoSize = True
        StateLabel.Location = New System.Drawing.Point(105, 189)
        StateLabel.Name = "StateLabel"
        StateLabel.Size = New System.Drawing.Size(31, 13)
        StateLabel.TabIndex = 6
        StateLabel.Text = "State:"
        '
        'CountryLabel
        '
        CountryLabel.AutoSize = True
        CountryLabel.Location = New System.Drawing.Point(94, 238)
        CountryLabel.Name = "CountryLabel"
        CountryLabel.Size = New System.Drawing.Size(42, 13)
        CountryLabel.TabIndex = 8
        CountryLabel.Text = "Country:"
        '
        'Job_TitleLabel
        '
        Job_TitleLabel.AutoSize = True
        Job_TitleLabel.Location = New System.Drawing.Point(80, 33)
        Job_TitleLabel.Name = "Job_TitleLabel"
        Job_TitleLabel.Size = New System.Drawing.Size(46, 13)
        Job_TitleLabel.TabIndex = 0
        Job_TitleLabel.Text = "Job Title:"
        '
        'DepartmentLabel
        '
        DepartmentLabel.AutoSize = True
        DepartmentLabel.Location = New System.Drawing.Point(65, 74)
        DepartmentLabel.Name = "DepartmentLabel"
        DepartmentLabel.Size = New System.Drawing.Size(61, 13)
        DepartmentLabel.TabIndex = 2
        DepartmentLabel.Text = "Department:"
        '
        'Department_GroupLabel
        '
        Department_GroupLabel.AutoSize = True
        Department_GroupLabel.Location = New System.Drawing.Point(33, 115)
        Department_GroupLabel.Name = "Department_GroupLabel"
        Department_GroupLabel.Size = New System.Drawing.Size(93, 13)
        Department_GroupLabel.TabIndex = 4
        Department_GroupLabel.Text = "Department Group:"
        '
        'Hire_DateLabel
        '
        Hire_DateLabel.AutoSize = True
        Hire_DateLabel.Location = New System.Drawing.Point(75, 198)
        Hire_DateLabel.Name = "Hire_DateLabel"
        Hire_DateLabel.Size = New System.Drawing.Size(51, 13)
        Hire_DateLabel.TabIndex = 6
        Hire_DateLabel.Text = "Hire Date:"
        '
        'ShiftLabel
        '
        ShiftLabel.AutoSize = True
        ShiftLabel.Location = New System.Drawing.Point(99, 156)
        ShiftLabel.Name = "ShiftLabel"
        ShiftLabel.Size = New System.Drawing.Size(27, 13)
        ShiftLabel.TabIndex = 8
        ShiftLabel.Text = "Shift:"
        '
        'Sick_LeaveLabel
        '
        Sick_LeaveLabel.AutoSize = True
        Sick_LeaveLabel.Location = New System.Drawing.Point(66, 238)
        Sick_LeaveLabel.Name = "Sick_LeaveLabel"
        Sick_LeaveLabel.Size = New System.Drawing.Size(60, 13)
        Sick_LeaveLabel.TabIndex = 10
        Sick_LeaveLabel.Text = "Sick Leave:"
        '
        'employeeDetailsTabControl
        '
        Me.employeeDetailsTabControl.Controls.Add(Me.employeeInfoTabPage)
        Me.employeeDetailsTabControl.Controls.Add(Me.addressTabPage)
        Me.employeeDetailsTabControl.Controls.Add(Me.employmentTabPage)
        Me.employeeDetailsTabControl.Location = New System.Drawing.Point(25, 50)
        Me.employeeDetailsTabControl.Name = "employeeDetailsTabControl"
        Me.employeeDetailsTabControl.SelectedIndex = 0
        Me.employeeDetailsTabControl.Size = New System.Drawing.Size(445, 330)
        Me.employeeDetailsTabControl.TabIndex = 0
        '
        'employeeInfoTabPage
        '
        Me.employeeInfoTabPage.AutoScroll = True
        Me.employeeInfoTabPage.Controls.Add(Birth_DateLabel)
        Me.employeeInfoTabPage.Controls.Add(Me.Birth_DateDateTimePicker)
        Me.employeeInfoTabPage.Controls.Add(PhoneLabel)
        Me.employeeInfoTabPage.Controls.Add(Me.PhoneTextBox)
        Me.employeeInfoTabPage.Controls.Add(EmailLabel)
        Me.employeeInfoTabPage.Controls.Add(Me.EmailTextBox)
        Me.employeeInfoTabPage.Controls.Add(Last_NameLabel)
        Me.employeeInfoTabPage.Controls.Add(Me.Last_NameTextBox)
        Me.employeeInfoTabPage.Controls.Add(First_NameLabel)
        Me.employeeInfoTabPage.Controls.Add(Me.First_NameTextBox)
        Me.employeeInfoTabPage.Controls.Add(TitleLabel)
        Me.employeeInfoTabPage.Controls.Add(Me.TitleTextBox)
        Me.employeeInfoTabPage.Location = New System.Drawing.Point(4, 22)
        Me.employeeInfoTabPage.Name = "employeeInfoTabPage"
        Me.employeeInfoTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.employeeInfoTabPage.Size = New System.Drawing.Size(437, 304)
        Me.employeeInfoTabPage.TabIndex = 0
        Me.employeeInfoTabPage.Text = "Employee Information"
        '
        'Birth_DateDateTimePicker
        '
        Me.Birth_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.VEmployeeDetailsBindingSource, "Birth Date", True))
        Me.Birth_DateDateTimePicker.Location = New System.Drawing.Point(142, 240)
        Me.Birth_DateDateTimePicker.Name = "Birth_DateDateTimePicker"
        Me.Birth_DateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Birth_DateDateTimePicker.TabIndex = 11
        '
        'VEmployeeDetailsBindingSource
        '
        Me.VEmployeeDetailsBindingSource.DataMember = "vEmployeeDetails"
        Me.VEmployeeDetailsBindingSource.DataSource = Me.EmployeeDetailsDataSet
        '
        'EmployeeDetailsDataSet
        '
        Me.EmployeeDetailsDataSet.DataSetName = "EmployeeDetailsDataSet"
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VEmployeeDetailsBindingSource, "Phone", True))
        Me.PhoneTextBox.Location = New System.Drawing.Point(142, 197)
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PhoneTextBox.TabIndex = 9
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VEmployeeDetailsBindingSource, "Email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(142, 154)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(200, 20)
        Me.EmailTextBox.TabIndex = 7
        '
        'Last_NameTextBox
        '
        Me.Last_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VEmployeeDetailsBindingSource, "Last Name", True))
        Me.Last_NameTextBox.Location = New System.Drawing.Point(142, 111)
        Me.Last_NameTextBox.Name = "Last_NameTextBox"
        Me.Last_NameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Last_NameTextBox.TabIndex = 5
        '
        'First_NameTextBox
        '
        Me.First_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VEmployeeDetailsBindingSource, "First Name", True))
        Me.First_NameTextBox.Location = New System.Drawing.Point(142, 68)
        Me.First_NameTextBox.Name = "First_NameTextBox"
        Me.First_NameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.First_NameTextBox.TabIndex = 3
        '
        'TitleTextBox
        '
        Me.TitleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VEmployeeDetailsBindingSource, "Title", True))
        Me.TitleTextBox.Location = New System.Drawing.Point(142, 25)
        Me.TitleTextBox.Name = "TitleTextBox"
        Me.TitleTextBox.Size = New System.Drawing.Size(40, 20)
        Me.TitleTextBox.TabIndex = 1
        '
        'addressTabPage
        '
        Me.addressTabPage.Controls.Add(CountryLabel)
        Me.addressTabPage.Controls.Add(Me.CountryTextBox)
        Me.addressTabPage.Controls.Add(StateLabel)
        Me.addressTabPage.Controls.Add(Me.StateTextBox)
        Me.addressTabPage.Controls.Add(Postal_CodeLabel)
        Me.addressTabPage.Controls.Add(Me.Postal_CodeTextBox)
        Me.addressTabPage.Controls.Add(CityLabel)
        Me.addressTabPage.Controls.Add(Me.CityTextBox)
        Me.addressTabPage.Controls.Add(AddressLine1Label)
        Me.addressTabPage.Controls.Add(Me.AddressLine1TextBox)
        Me.addressTabPage.Location = New System.Drawing.Point(4, 22)
        Me.addressTabPage.Name = "addressTabPage"
        Me.addressTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.addressTabPage.Size = New System.Drawing.Size(437, 304)
        Me.addressTabPage.TabIndex = 1
        Me.addressTabPage.Text = "Address Details"
        '
        'CountryTextBox
        '
        Me.CountryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VEmployeeDetailsBindingSource, "Country", True))
        Me.CountryTextBox.Location = New System.Drawing.Point(153, 235)
        Me.CountryTextBox.Name = "CountryTextBox"
        Me.CountryTextBox.Size = New System.Drawing.Size(150, 20)
        Me.CountryTextBox.TabIndex = 9
        '
        'StateTextBox
        '
        Me.StateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VEmployeeDetailsBindingSource, "State", True))
        Me.StateTextBox.Location = New System.Drawing.Point(153, 186)
        Me.StateTextBox.Name = "StateTextBox"
        Me.StateTextBox.Size = New System.Drawing.Size(150, 20)
        Me.StateTextBox.TabIndex = 7
        '
        'Postal_CodeTextBox
        '
        Me.Postal_CodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VEmployeeDetailsBindingSource, "Postal Code", True))
        Me.Postal_CodeTextBox.Location = New System.Drawing.Point(153, 137)
        Me.Postal_CodeTextBox.Name = "Postal_CodeTextBox"
        Me.Postal_CodeTextBox.Size = New System.Drawing.Size(150, 20)
        Me.Postal_CodeTextBox.TabIndex = 5
        '
        'CityTextBox
        '
        Me.CityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VEmployeeDetailsBindingSource, "City", True))
        Me.CityTextBox.Location = New System.Drawing.Point(153, 88)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(150, 20)
        Me.CityTextBox.TabIndex = 3
        '
        'AddressLine1TextBox
        '
        Me.AddressLine1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VEmployeeDetailsBindingSource, "AddressLine1", True))
        Me.AddressLine1TextBox.Location = New System.Drawing.Point(153, 39)
        Me.AddressLine1TextBox.Name = "AddressLine1TextBox"
        Me.AddressLine1TextBox.Size = New System.Drawing.Size(150, 20)
        Me.AddressLine1TextBox.TabIndex = 1
        '
        'employmentTabPage
        '
        Me.employmentTabPage.AutoScroll = True
        Me.employmentTabPage.Controls.Add(Sick_LeaveLabel)
        Me.employmentTabPage.Controls.Add(Me.Sick_LeaveTextBox)
        Me.employmentTabPage.Controls.Add(ShiftLabel)
        Me.employmentTabPage.Controls.Add(Me.ShiftTextBox)
        Me.employmentTabPage.Controls.Add(Hire_DateLabel)
        Me.employmentTabPage.Controls.Add(Me.Hire_DateDateTimePicker)
        Me.employmentTabPage.Controls.Add(Department_GroupLabel)
        Me.employmentTabPage.Controls.Add(Me.Department_GroupTextBox)
        Me.employmentTabPage.Controls.Add(DepartmentLabel)
        Me.employmentTabPage.Controls.Add(Me.DepartmentTextBox)
        Me.employmentTabPage.Controls.Add(Job_TitleLabel)
        Me.employmentTabPage.Controls.Add(Me.Job_TitleTextBox)
        Me.employmentTabPage.Location = New System.Drawing.Point(4, 22)
        Me.employmentTabPage.Name = "employmentTabPage"
        Me.employmentTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.employmentTabPage.Size = New System.Drawing.Size(437, 304)
        Me.employmentTabPage.TabIndex = 2
        Me.employmentTabPage.Text = "Employment Details"
        '
        'Sick_LeaveTextBox
        '
        Me.Sick_LeaveTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VEmployeeDetailsBindingSource, "Sick Leave", True))
        Me.Sick_LeaveTextBox.Location = New System.Drawing.Point(133, 235)
        Me.Sick_LeaveTextBox.Name = "Sick_LeaveTextBox"
        Me.Sick_LeaveTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Sick_LeaveTextBox.TabIndex = 11
        '
        'ShiftTextBox
        '
        Me.ShiftTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VEmployeeDetailsBindingSource, "Shift", True))
        Me.ShiftTextBox.Location = New System.Drawing.Point(133, 153)
        Me.ShiftTextBox.Name = "ShiftTextBox"
        Me.ShiftTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ShiftTextBox.TabIndex = 9
        '
        'Hire_DateDateTimePicker
        '
        Me.Hire_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.VEmployeeDetailsBindingSource, "Hire Date", True))
        Me.Hire_DateDateTimePicker.Location = New System.Drawing.Point(133, 194)
        Me.Hire_DateDateTimePicker.Name = "Hire_DateDateTimePicker"
        Me.Hire_DateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Hire_DateDateTimePicker.TabIndex = 7
        Me.Hire_DateDateTimePicker.TabStop = False
        '
        'Department_GroupTextBox
        '
        Me.Department_GroupTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VEmployeeDetailsBindingSource, "Department Group", True))
        Me.Department_GroupTextBox.Location = New System.Drawing.Point(133, 112)
        Me.Department_GroupTextBox.Name = "Department_GroupTextBox"
        Me.Department_GroupTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Department_GroupTextBox.TabIndex = 5
        '
        'DepartmentTextBox
        '
        Me.DepartmentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VEmployeeDetailsBindingSource, "Department", True))
        Me.DepartmentTextBox.Location = New System.Drawing.Point(133, 71)
        Me.DepartmentTextBox.Name = "DepartmentTextBox"
        Me.DepartmentTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DepartmentTextBox.TabIndex = 3
        '
        'Job_TitleTextBox
        '
        Me.Job_TitleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VEmployeeDetailsBindingSource, "Job Title", True))
        Me.Job_TitleTextBox.Location = New System.Drawing.Point(133, 30)
        Me.Job_TitleTextBox.Name = "Job_TitleTextBox"
        Me.Job_TitleTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Job_TitleTextBox.TabIndex = 1
        '
        'VEmployeeDetailsBindingNavigator
        '
        Me.VEmployeeDetailsBindingNavigator.AddNewItem = Nothing
        Me.VEmployeeDetailsBindingNavigator.BindingSource = Me.VEmployeeDetailsBindingSource
        Me.VEmployeeDetailsBindingNavigator.CountItem = Me.bindingNavigatorCountItem
        Me.VEmployeeDetailsBindingNavigator.CountItemFormat = "of {0}"
        Me.VEmployeeDetailsBindingNavigator.DeleteItem = Nothing
        Me.VEmployeeDetailsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bindingNavigatorMoveFirstItem, Me.bindingNavigatorMovePreviousItem, Me.bindingNavigatorSeparator, Me.bindingNavigatorPositionItem, Me.bindingNavigatorCountItem, Me.bindingNavigatorSeparator1, Me.bindingNavigatorMoveNextItem, Me.bindingNavigatorMoveLastItem, Me.bindingNavigatorSeparator2, Me.closeToolStripButton})
        Me.VEmployeeDetailsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.VEmployeeDetailsBindingNavigator.MoveFirstItem = Me.bindingNavigatorMoveFirstItem
        Me.VEmployeeDetailsBindingNavigator.MoveLastItem = Me.bindingNavigatorMoveLastItem
        Me.VEmployeeDetailsBindingNavigator.MoveNextItem = Me.bindingNavigatorMoveNextItem
        Me.VEmployeeDetailsBindingNavigator.MovePreviousItem = Me.bindingNavigatorMovePreviousItem
        Me.VEmployeeDetailsBindingNavigator.Name = "VEmployeeDetailsBindingNavigator"
        Me.VEmployeeDetailsBindingNavigator.PositionItem = Me.bindingNavigatorPositionItem
        Me.VEmployeeDetailsBindingNavigator.Size = New System.Drawing.Size(502, 25)
        Me.VEmployeeDetailsBindingNavigator.TabIndex = 1
        Me.VEmployeeDetailsBindingNavigator.Text = "BindingNavigator1"
        '
        'bindingNavigatorCountItem
        '
        Me.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem"
        Me.bindingNavigatorCountItem.Text = "of {0}"
        Me.bindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'bindingNavigatorMoveFirstItem
        '
        Me.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("bindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem"
        Me.bindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'bindingNavigatorMovePreviousItem
        '
        Me.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("bindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem"
        Me.bindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'bindingNavigatorSeparator
        '
        Me.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator"
        '
        'bindingNavigatorPositionItem
        '
        Me.bindingNavigatorPositionItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
        Me.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem"
        Me.bindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 25)
        Me.bindingNavigatorPositionItem.Text = "0"
        Me.bindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'bindingNavigatorSeparator1
        '
        Me.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1"
        '
        'bindingNavigatorMoveNextItem
        '
        Me.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bindingNavigatorMoveNextItem.Image = CType(resources.GetObject("bindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem"
        Me.bindingNavigatorMoveNextItem.Text = "Move next"
        '
        'bindingNavigatorMoveLastItem
        '
        Me.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bindingNavigatorMoveLastItem.Image = CType(resources.GetObject("bindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem"
        Me.bindingNavigatorMoveLastItem.Text = "Move last"
        '
        'bindingNavigatorSeparator2
        '
        Me.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2"
        '
        'closeToolStripButton
        '
        Me.closeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.closeToolStripButton.Image = CType(resources.GetObject("closeToolStripButton.Image"), System.Drawing.Image)
        Me.closeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.closeToolStripButton.Name = "closeToolStripButton"
        Me.closeToolStripButton.Text = "Close Form"
        '
        'VEmployeeDetailsTableAdapter
        '
        Me.VEmployeeDetailsTableAdapter.ClearBeforeFill = True
        '
        'EmployeeDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(502, 403)
        Me.Controls.Add(Me.employeeDetailsTabControl)
        Me.Controls.Add(Me.VEmployeeDetailsBindingNavigator)
        Me.Name = "EmployeeDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee Details"
        Me.employeeDetailsTabControl.ResumeLayout(False)
        Me.employeeInfoTabPage.ResumeLayout(False)
        Me.employeeInfoTabPage.PerformLayout()
        CType(Me.VEmployeeDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeDetailsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.addressTabPage.ResumeLayout(False)
        Me.addressTabPage.PerformLayout()
        Me.employmentTabPage.ResumeLayout(False)
        Me.employmentTabPage.PerformLayout()
        CType(Me.VEmployeeDetailsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.VEmployeeDetailsBindingNavigator.ResumeLayout(False)
        Me.VEmployeeDetailsBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents employeeDetailsTabControl As System.Windows.Forms.TabControl
    Friend WithEvents employeeInfoTabPage As System.Windows.Forms.TabPage
    Friend WithEvents addressTabPage As System.Windows.Forms.TabPage
    Friend WithEvents employmentTabPage As System.Windows.Forms.TabPage
    Friend WithEvents VEmployeeDetailsBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents bindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents bindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents bindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents bindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents bindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Birth_DateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents PhoneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Last_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents First_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TitleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CountryTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Postal_CodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddressLine1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Sick_LeaveTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ShiftTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Hire_DateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Department_GroupTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DepartmentTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Job_TitleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents bindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents bindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents bindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents bindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents closeToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents VEmployeeDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmployeeDetailsDataSet As AWEViewerVB.EmployeeDetailsDataSet
    Friend WithEvents VEmployeeDetailsTableAdapter As AWEViewerVB.EmployeeDetailsDataSetTableAdapters.vEmployeeDetailsTableAdapter
End Class
