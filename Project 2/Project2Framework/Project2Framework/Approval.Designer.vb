<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Approval
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPeriods = New System.Windows.Forms.TextBox()
        Me.txtInterest = New System.Windows.Forms.TextBox()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.Periods = New System.Windows.Forms.Label()
        Me.Interest = New System.Windows.Forms.Label()
        Me.LoanAmount = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtFuture = New System.Windows.Forms.TextBox()
        Me.Future = New System.Windows.Forms.Label()
        Me.txtCurrent = New System.Windows.Forms.TextBox()
        Me.Current = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Calculate = New System.Windows.Forms.Button()
        Me.Close = New System.Windows.Forms.Button()
        Me.Proceed = New System.Windows.Forms.Button()
        Me.Reject = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtPeriods)
        Me.Panel1.Controls.Add(Me.txtInterest)
        Me.Panel1.Controls.Add(Me.txtAmount)
        Me.Panel1.Controls.Add(Me.Periods)
        Me.Panel1.Controls.Add(Me.Interest)
        Me.Panel1.Controls.Add(Me.LoanAmount)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(302, 173)
        Me.Panel1.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(239, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(21, 20)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "%"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(239, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 20)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Months"
        '
        'txtPeriods
        '
        Me.txtPeriods.Location = New System.Drawing.Point(110, 125)
        Me.txtPeriods.Name = "txtPeriods"
        Me.txtPeriods.Size = New System.Drawing.Size(123, 20)
        Me.txtPeriods.TabIndex = 14
        '
        'txtInterest
        '
        Me.txtInterest.Location = New System.Drawing.Point(110, 87)
        Me.txtInterest.Name = "txtInterest"
        Me.txtInterest.Size = New System.Drawing.Size(123, 20)
        Me.txtInterest.TabIndex = 13
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(110, 48)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(123, 20)
        Me.txtAmount.TabIndex = 12
        '
        'Periods
        '
        Me.Periods.AutoSize = True
        Me.Periods.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Periods.Location = New System.Drawing.Point(48, 123)
        Me.Periods.Name = "Periods"
        Me.Periods.Size = New System.Drawing.Size(56, 20)
        Me.Periods.TabIndex = 11
        Me.Periods.Text = "Periods"
        '
        'Interest
        '
        Me.Interest.AutoSize = True
        Me.Interest.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Interest.Location = New System.Drawing.Point(52, 85)
        Me.Interest.Name = "Interest"
        Me.Interest.Size = New System.Drawing.Size(52, 20)
        Me.Interest.TabIndex = 10
        Me.Interest.Text = "Interest"
        '
        'LoanAmount
        '
        Me.LoanAmount.AutoSize = True
        Me.LoanAmount.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoanAmount.Location = New System.Drawing.Point(17, 46)
        Me.LoanAmount.Name = "LoanAmount"
        Me.LoanAmount.Size = New System.Drawing.Size(87, 20)
        Me.LoanAmount.TabIndex = 9
        Me.LoanAmount.Text = "Loan Amount"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Black", 16.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Label3.Location = New System.Drawing.Point(-6, 0)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(165, 31)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Loan Details"
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(0, 206)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(323, 166)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.txtFuture)
        Me.Panel3.Controls.Add(Me.Future)
        Me.Panel3.Controls.Add(Me.txtCurrent)
        Me.Panel3.Controls.Add(Me.Current)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Location = New System.Drawing.Point(12, 191)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(302, 132)
        Me.Panel3.TabIndex = 1
        '
        'txtFuture
        '
        Me.txtFuture.Location = New System.Drawing.Point(110, 83)
        Me.txtFuture.Name = "txtFuture"
        Me.txtFuture.Size = New System.Drawing.Size(123, 20)
        Me.txtFuture.TabIndex = 18
        '
        'Future
        '
        Me.Future.AutoSize = True
        Me.Future.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Future.Location = New System.Drawing.Point(11, 83)
        Me.Future.Name = "Future"
        Me.Future.Size = New System.Drawing.Size(93, 20)
        Me.Future.TabIndex = 17
        Me.Future.Text = "Future Interest"
        '
        'txtCurrent
        '
        Me.txtCurrent.Location = New System.Drawing.Point(110, 46)
        Me.txtCurrent.Name = "txtCurrent"
        Me.txtCurrent.Size = New System.Drawing.Size(123, 20)
        Me.txtCurrent.TabIndex = 16
        '
        'Current
        '
        Me.Current.AutoSize = True
        Me.Current.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Current.Location = New System.Drawing.Point(6, 46)
        Me.Current.Name = "Current"
        Me.Current.Size = New System.Drawing.Size(98, 20)
        Me.Current.TabIndex = 15
        Me.Current.Text = "Current Interest"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 16.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Label1.Location = New System.Drawing.Point(-6, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 31)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Interest"
        '
        'Panel4
        '
        Me.Panel4.Location = New System.Drawing.Point(0, 206)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(323, 166)
        Me.Panel4.TabIndex = 1
        '
        'Calculate
        '
        Me.Calculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Calculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Calculate.ForeColor = System.Drawing.Color.Black
        Me.Calculate.Location = New System.Drawing.Point(335, 12)
        Me.Calculate.Name = "Calculate"
        Me.Calculate.Size = New System.Drawing.Size(116, 33)
        Me.Calculate.TabIndex = 23
        Me.Calculate.Text = "Calculate"
        Me.Calculate.UseVisualStyleBackColor = True
        '
        'Close
        '
        Me.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Close.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Close.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Close.Location = New System.Drawing.Point(335, 60)
        Me.Close.Name = "Close"
        Me.Close.Size = New System.Drawing.Size(116, 33)
        Me.Close.TabIndex = 24
        Me.Close.Text = "Close"
        Me.Close.UseVisualStyleBackColor = True
        '
        'Proceed
        '
        Me.Proceed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Proceed.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Proceed.ForeColor = System.Drawing.Color.Lime
        Me.Proceed.Location = New System.Drawing.Point(335, 110)
        Me.Proceed.Name = "Proceed"
        Me.Proceed.Size = New System.Drawing.Size(116, 33)
        Me.Proceed.TabIndex = 25
        Me.Proceed.Text = "Proceed"
        Me.Proceed.UseVisualStyleBackColor = True
        '
        'Reject
        '
        Me.Reject.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Reject.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Reject.ForeColor = System.Drawing.Color.Red
        Me.Reject.Location = New System.Drawing.Point(335, 161)
        Me.Reject.Name = "Reject"
        Me.Reject.Size = New System.Drawing.Size(116, 33)
        Me.Reject.TabIndex = 26
        Me.Reject.Text = "Reject"
        Me.Reject.UseVisualStyleBackColor = True
        '
        'Approval
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 334)
        Me.Controls.Add(Me.Reject)
        Me.Controls.Add(Me.Proceed)
        Me.Controls.Add(Me.Close)
        Me.Controls.Add(Me.Calculate)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Approval"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loan Approval Form"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents Periods As Label
    Friend WithEvents Interest As Label
    Friend WithEvents LoanAmount As Label
    Friend WithEvents txtPeriods As TextBox
    Friend WithEvents txtInterest As TextBox
    Friend WithEvents txtFuture As TextBox
    Friend WithEvents Future As Label
    Friend WithEvents txtCurrent As TextBox
    Friend WithEvents Current As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Calculate As Button
    Friend WithEvents Close As Button
    Friend WithEvents Proceed As Button
    Friend WithEvents Reject As Button
End Class
