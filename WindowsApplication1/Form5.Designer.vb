<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Product_idLabel.Location = New System.Drawing.Point(79, 141)
        Product_idLabel.Name = "Product_idLabel"
        Product_idLabel.Size = New System.Drawing.Size(58, 13)
        Product_idLabel.TabIndex = 26
        Product_idLabel.Text = "Product id:"
        '
        'BrandLabel
        '
        BrandLabel.AutoSize = True
        BrandLabel.Location = New System.Drawing.Point(80, 176)
        BrandLabel.Name = "BrandLabel"
        BrandLabel.Size = New System.Drawing.Size(38, 13)
        BrandLabel.TabIndex = 28
        BrandLabel.Text = "Brand:"
        '
        'ModelLabel
        '
        ModelLabel.AutoSize = True
        ModelLabel.Location = New System.Drawing.Point(79, 217)
        ModelLabel.Name = "ModelLabel"
        ModelLabel.Size = New System.Drawing.Size(39, 13)
        ModelLabel.TabIndex = 30
        ModelLabel.Text = "Model:"
        '
        'QuantityLabel
        '
        QuantityLabel.AutoSize = True
        QuantityLabel.Location = New System.Drawing.Point(80, 254)
        QuantityLabel.Name = "QuantityLabel"
        QuantityLabel.Size = New System.Drawing.Size(49, 13)
        QuantityLabel.TabIndex = 32
        QuantityLabel.Text = "Quantity:"
        '
        'PriceLabel
        '
        PriceLabel.AutoSize = True
        PriceLabel.Location = New System.Drawing.Point(80, 292)
        PriceLabel.Name = "PriceLabel"
        PriceLabel.Size = New System.Drawing.Size(34, 13)
        PriceLabel.TabIndex = 34
        PriceLabel.Text = "Price:"
        '
        'ColourLabel
        '
        ColourLabel.AutoSize = True
        ColourLabel.Location = New System.Drawing.Point(80, 329)
        ColourLabel.Name = "ColourLabel"
        ColourLabel.Size = New System.Drawing.Size(40, 13)
        ColourLabel.TabIndex = 36
        ColourLabel.Text = "Colour:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(329, 306)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 36)
        Me.Button1.TabIndex = 38
        Me.Button1.Text = "DELETE STOCK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Product_idTextBox
        '
        Me.Product_idTextBox.Location = New System.Drawing.Point(162, 134)
        Me.Product_idTextBox.Name = "Product_idTextBox"
        Me.Product_idTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Product_idTextBox.TabIndex = 27
        '
        'BrandTextBox
        '
        Me.BrandTextBox.Location = New System.Drawing.Point(162, 176)
        Me.BrandTextBox.Name = "BrandTextBox"
        Me.BrandTextBox.Size = New System.Drawing.Size(100, 20)
        Me.BrandTextBox.TabIndex = 29
        '
        'ModelTextBox
        '
        Me.ModelTextBox.Location = New System.Drawing.Point(162, 214)
        Me.ModelTextBox.Name = "ModelTextBox"
        Me.ModelTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ModelTextBox.TabIndex = 31
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.Location = New System.Drawing.Point(162, 247)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(100, 20)
        Me.QuantityTextBox.TabIndex = 33
        '
        'PriceTextBox
        '
        Me.PriceTextBox.Location = New System.Drawing.Point(162, 285)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PriceTextBox.TabIndex = 35
        '
        'ColourTextBox
        '
        Me.ColourTextBox.Location = New System.Drawing.Point(162, 322)
        Me.ColourTextBox.Name = "ColourTextBox"
        Me.ColourTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ColourTextBox.TabIndex = 37
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Jokerman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(138, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(326, 39)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "NEXGEN INVENTORY"
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(662, 382)
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
        Me.Name = "Form5"
        Me.Text = "Form5"
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
