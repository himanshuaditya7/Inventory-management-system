<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Product_idLabel.Location = New System.Drawing.Point(55, 117)
        Product_idLabel.Name = "Product_idLabel"
        Product_idLabel.Size = New System.Drawing.Size(76, 15)
        Product_idLabel.TabIndex = 14
        Product_idLabel.Text = "Product id:"
        '
        'BrandLabel
        '
        BrandLabel.AutoSize = True
        BrandLabel.Font = New System.Drawing.Font("Modern No. 20", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BrandLabel.ForeColor = System.Drawing.Color.DarkRed
        BrandLabel.Location = New System.Drawing.Point(69, 155)
        BrandLabel.Name = "BrandLabel"
        BrandLabel.Size = New System.Drawing.Size(49, 15)
        BrandLabel.TabIndex = 16
        BrandLabel.Text = "Brand:"
        '
        'ModelLabel
        '
        ModelLabel.AutoSize = True
        ModelLabel.Font = New System.Drawing.Font("Modern No. 20", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ModelLabel.ForeColor = System.Drawing.Color.DarkRed
        ModelLabel.Location = New System.Drawing.Point(69, 194)
        ModelLabel.Name = "ModelLabel"
        ModelLabel.Size = New System.Drawing.Size(48, 15)
        ModelLabel.TabIndex = 18
        ModelLabel.Text = "Model:"
        '
        'QuantityLabel
        '
        QuantityLabel.AutoSize = True
        QuantityLabel.Font = New System.Drawing.Font("Modern No. 20", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        QuantityLabel.ForeColor = System.Drawing.Color.DarkRed
        QuantityLabel.Location = New System.Drawing.Point(69, 232)
        QuantityLabel.Name = "QuantityLabel"
        QuantityLabel.Size = New System.Drawing.Size(65, 15)
        QuantityLabel.TabIndex = 20
        QuantityLabel.Text = "Quantity:"
        '
        'PriceLabel
        '
        PriceLabel.AutoSize = True
        PriceLabel.Font = New System.Drawing.Font("Modern No. 20", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PriceLabel.ForeColor = System.Drawing.Color.DarkRed
        PriceLabel.Location = New System.Drawing.Point(73, 281)
        PriceLabel.Name = "PriceLabel"
        PriceLabel.Size = New System.Drawing.Size(43, 15)
        PriceLabel.TabIndex = 22
        PriceLabel.Text = "Price:"
        '
        'ColourLabel
        '
        ColourLabel.AutoSize = True
        ColourLabel.Font = New System.Drawing.Font("Modern No. 20", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ColourLabel.ForeColor = System.Drawing.Color.DarkRed
        ColourLabel.Location = New System.Drawing.Point(73, 320)
        ColourLabel.Name = "ColourLabel"
        ColourLabel.Size = New System.Drawing.Size(52, 15)
        ColourLabel.TabIndex = 24
        ColourLabel.Text = "Colour:"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(336, 317)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 23)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "ADD STOCK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Product_idTextBox
        '
        Me.Product_idTextBox.Location = New System.Drawing.Point(203, 114)
        Me.Product_idTextBox.Name = "Product_idTextBox"
        Me.Product_idTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Product_idTextBox.TabIndex = 15
        '
        'BrandTextBox
        '
        Me.BrandTextBox.Location = New System.Drawing.Point(203, 155)
        Me.BrandTextBox.Name = "BrandTextBox"
        Me.BrandTextBox.Size = New System.Drawing.Size(100, 20)
        Me.BrandTextBox.TabIndex = 17
        '
        'ModelTextBox
        '
        Me.ModelTextBox.Location = New System.Drawing.Point(203, 194)
        Me.ModelTextBox.Name = "ModelTextBox"
        Me.ModelTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ModelTextBox.TabIndex = 19
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.Location = New System.Drawing.Point(203, 232)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(100, 20)
        Me.QuantityTextBox.TabIndex = 21
        '
        'PriceTextBox
        '
        Me.PriceTextBox.Location = New System.Drawing.Point(203, 278)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PriceTextBox.TabIndex = 23
        '
        'ColourTextBox
        '
        Me.ColourTextBox.Location = New System.Drawing.Point(203, 317)
        Me.ColourTextBox.Name = "ColourTextBox"
        Me.ColourTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ColourTextBox.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Jokerman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(85, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(326, 39)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "NEXGEN INVENTORY"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.SM_T805NZWATGY_78_0
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(548, 451)
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
        Me.Name = "Form4"
        Me.Text = "Form4"
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
