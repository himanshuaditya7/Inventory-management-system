<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Dim Product_idLabel As System.Windows.Forms.Label
        Dim BrandLabel As System.Windows.Forms.Label
        Dim ModelLabel As System.Windows.Forms.Label
        Dim QuantityLabel As System.Windows.Forms.Label
        Dim PriceLabel As System.Windows.Forms.Label
        Dim ColourLabel As System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Product_idTextBox = New System.Windows.Forms.TextBox()
        Me.BrandTextBox = New System.Windows.Forms.TextBox()
        Me.ModelTextBox = New System.Windows.Forms.TextBox()
        Me.QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.ColourTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Product_idLabel = New System.Windows.Forms.Label()
        BrandLabel = New System.Windows.Forms.Label()
        ModelLabel = New System.Windows.Forms.Label()
        QuantityLabel = New System.Windows.Forms.Label()
        PriceLabel = New System.Windows.Forms.Label()
        ColourLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Product_idLabel
        '
        Product_idLabel.AutoSize = True
        Product_idLabel.Font = New System.Drawing.Font("Modern No. 20", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Product_idLabel.ForeColor = System.Drawing.Color.DarkRed
        Product_idLabel.Location = New System.Drawing.Point(44, 203)
        Product_idLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Product_idLabel.Name = "Product_idLabel"
        Product_idLabel.Size = New System.Drawing.Size(97, 20)
        Product_idLabel.TabIndex = 27
        Product_idLabel.Text = "Product id:"
        '
        'BrandLabel
        '
        BrandLabel.AutoSize = True
        BrandLabel.Font = New System.Drawing.Font("Modern No. 20", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BrandLabel.ForeColor = System.Drawing.Color.DarkRed
        BrandLabel.Location = New System.Drawing.Point(63, 250)
        BrandLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        BrandLabel.Name = "BrandLabel"
        BrandLabel.Size = New System.Drawing.Size(63, 20)
        BrandLabel.TabIndex = 29
        BrandLabel.Text = "Brand:"
        '
        'ModelLabel
        '
        ModelLabel.AutoSize = True
        ModelLabel.Font = New System.Drawing.Font("Modern No. 20", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ModelLabel.ForeColor = System.Drawing.Color.DarkRed
        ModelLabel.Location = New System.Drawing.Point(63, 298)
        ModelLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ModelLabel.Name = "ModelLabel"
        ModelLabel.Size = New System.Drawing.Size(62, 20)
        ModelLabel.TabIndex = 31
        ModelLabel.Text = "Model:"
        '
        'QuantityLabel
        '
        QuantityLabel.AutoSize = True
        QuantityLabel.Font = New System.Drawing.Font("Modern No. 20", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        QuantityLabel.ForeColor = System.Drawing.Color.DarkRed
        QuantityLabel.Location = New System.Drawing.Point(63, 345)
        QuantityLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        QuantityLabel.Name = "QuantityLabel"
        QuantityLabel.Size = New System.Drawing.Size(82, 20)
        QuantityLabel.TabIndex = 33
        QuantityLabel.Text = "Quantity:"
        '
        'PriceLabel
        '
        PriceLabel.AutoSize = True
        PriceLabel.Font = New System.Drawing.Font("Modern No. 20", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PriceLabel.ForeColor = System.Drawing.Color.DarkRed
        PriceLabel.Location = New System.Drawing.Point(68, 405)
        PriceLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PriceLabel.Name = "PriceLabel"
        PriceLabel.Size = New System.Drawing.Size(56, 20)
        PriceLabel.TabIndex = 35
        PriceLabel.Text = "Price:"
        '
        'ColourLabel
        '
        ColourLabel.AutoSize = True
        ColourLabel.Font = New System.Drawing.Font("Modern No. 20", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ColourLabel.ForeColor = System.Drawing.Color.DarkRed
        ColourLabel.Location = New System.Drawing.Point(68, 453)
        ColourLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ColourLabel.Name = "ColourLabel"
        ColourLabel.Size = New System.Drawing.Size(66, 20)
        ColourLabel.TabIndex = 37
        ColourLabel.Text = "Colour:"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Magneto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(452, 437)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 34)
        Me.Button1.TabIndex = 39
        Me.Button1.Text = "UPDATE"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Product_idTextBox
        '
        Me.Product_idTextBox.Location = New System.Drawing.Point(241, 199)
        Me.Product_idTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Product_idTextBox.Name = "Product_idTextBox"
        Me.Product_idTextBox.Size = New System.Drawing.Size(132, 22)
        Me.Product_idTextBox.TabIndex = 28
        '
        'BrandTextBox
        '
        Me.BrandTextBox.Location = New System.Drawing.Point(241, 250)
        Me.BrandTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.BrandTextBox.Name = "BrandTextBox"
        Me.BrandTextBox.Size = New System.Drawing.Size(132, 22)
        Me.BrandTextBox.TabIndex = 30
        '
        'ModelTextBox
        '
        Me.ModelTextBox.Location = New System.Drawing.Point(241, 298)
        Me.ModelTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ModelTextBox.Name = "ModelTextBox"
        Me.ModelTextBox.Size = New System.Drawing.Size(132, 22)
        Me.ModelTextBox.TabIndex = 32
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.Location = New System.Drawing.Point(241, 345)
        Me.QuantityTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(132, 22)
        Me.QuantityTextBox.TabIndex = 34
        '
        'PriceTextBox
        '
        Me.PriceTextBox.Location = New System.Drawing.Point(241, 401)
        Me.PriceTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.Size = New System.Drawing.Size(132, 22)
        Me.PriceTextBox.TabIndex = 36
        '
        'ColourTextBox
        '
        Me.ColourTextBox.Location = New System.Drawing.Point(241, 449)
        Me.ColourTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ColourTextBox.Name = "ColourTextBox"
        Me.ColourTextBox.Size = New System.Drawing.Size(132, 22)
        Me.ColourTextBox.TabIndex = 38
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Jokerman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(39, 47)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(407, 49)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "NEXGEN INVENTORY"
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.spade_mark_banner
        Me.ClientSize = New System.Drawing.Size(943, 523)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Product_idLabel)
        Me.Controls.Add(Me.Product_idTextBox)
        Me.Controls.Add(BrandLabel)
        Me.Controls.Add(Me.BrandTextBox)
        Me.Controls.Add(ModelLabel)
        Me.Controls.Add(Me.ModelTextBox)
        Me.Controls.Add(QuantityLabel)
        Me.Controls.Add(Me.QuantityTextBox)
        Me.Controls.Add(PriceLabel)
        Me.Controls.Add(Me.PriceTextBox)
        Me.Controls.Add(ColourLabel)
        Me.Controls.Add(Me.ColourTextBox)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form7"
        Me.Text = "Form7"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Product_idTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BrandTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ModelTextBox As System.Windows.Forms.TextBox
    Friend WithEvents QuantityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ColourTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
