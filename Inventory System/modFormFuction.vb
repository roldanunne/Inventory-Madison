Imports System.Security.Cryptography
Imports System.Text
Imports System.IO

Module modFormFuction

    Public Sub mdiChildClosed(ByVal mdi As Form)
        For Each frm As Form In mdi.MdiChildren
            frm.Close()
        Next
    End Sub

    Public Sub setCenterPanel(ByVal frm As Form, ByVal panelData As Panel)
        panelData.Location = New Point((frm.Width / 2) - (panelData.Width / 2), (frm.Height / 2) - (panelData.Height / 2))
        panelData.BringToFront()
    End Sub

    Public Sub setLocked(ByVal ctrlContainer As Control, ByVal bolValue As Boolean)
        For Each ctrl As Control In ctrlContainer.Controls
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).ReadOnly = Not bolValue
            End If
            If TypeOf ctrl Is ComboBox Then
                ctrl.Enabled = bolValue
            End If
            If TypeOf ctrl Is DateTimePicker Then
                ctrl.Enabled = bolValue
            End If
            If TypeOf ctrl Is PictureBox Then
                CType(ctrl, PictureBox).Enabled = bolValue
            End If
            If ctrl.HasChildren Then
                setLocked(ctrl, bolValue)
            End If
        Next
    End Sub

    Public Sub setClearAll(ByVal ctrlContainer As Control)
        For Each ctrl As Control In ctrlContainer.Controls
            If TypeOf ctrl Is TextBox Then
                ctrl.Text = ""
            End If
            If TypeOf ctrl Is ComboBox Then
                ctrl.Text = ""
            End If
            If TypeOf ctrl Is CheckBox Then
                CType(ctrl, CheckBox).CheckState = CheckState.Unchecked
            End If
            If TypeOf ctrl Is PictureBox Then
                CType(ctrl, PictureBox).Image = My.Resources.noImage
            End If
            If ctrl.HasChildren Then
                setClearAll(ctrl)
            End If
        Next
    End Sub

    Public Function setIsTextEmpty(ByVal ctrlContainer As Control) As Boolean
        For Each ctrl As Control In ctrlContainer.Controls
            If TypeOf ctrl Is TextBox Then
                If ctrl.Text = String.Empty Then
                    Return True
                End If
            End If
            If TypeOf ctrl Is ComboBox Then
                If CType(ctrl, ComboBox).Text = String.Empty Then
                    Return True
                End If
            End If
            If ctrl.HasChildren Then
                setIsTextEmpty(ctrl)
            End If
        Next
        Return False
    End Function

    Public Function ImageToBytes(ByVal Image As Image) As Byte()
        Dim memImage As New System.IO.MemoryStream
        Dim bytImage() As Byte
        Image.Save(memImage, Image.RawFormat)
        bytImage = memImage.GetBuffer()
        Return bytImage
    End Function

    Public Function BytesToImage(ByVal ImageBytes() As Byte) As Image
        Dim memImage As New System.IO.MemoryStream(ImageBytes)
        Dim imgNew As Image
        imgNew = Image.FromStream(memImage)
        Return imgNew
    End Function

    Public Sub cboDup(ByVal cbo As ComboBox)
        For i As Int16 = 0 To cbo.Items.Count - 2
            For j As Int16 = cbo.Items.Count - 1 To i + 1 Step -1
                If cbo.Items(i).ToString = cbo.Items(j).ToString Then
                    cbo.Items.RemoveAt(j)
                End If
            Next
        Next
    End Sub

    Public Function DataGridRowDuplicates(ByVal DataGridName As DataGridView, ByVal strItemCode As String) As Boolean
        DataGridRowDuplicates = False
        Dim Exists As Boolean = False
        For Each dgItem As DataGridViewRow In DataGridName.Rows
            If dgItem.Cells(0).Value = strItemCode Then
                Exists = True
            End If
        Next

        If DataGridName.Rows.Count > 0 AndAlso Exists = True Then
            MessageBox.Show("This Subject is Already Exist!...")
            DataGridRowDuplicates = True
        End If
        Return DataGridRowDuplicates
    End Function

    Public Function isOpened(ByVal frm As Form) As Boolean
        Dim frmCol As New FormCollection()
        frmCol = Application.OpenForms
        Dim Cnt As Integer = 0
        For Each f As Form In frmCol
            If f.Name = frm.Name Then Cnt += 1
        Next
        Return IIf(Cnt > 0, True, False)
    End Function

    'newly added
    Public Sub productIsEmpty(ByVal txtProdName As String, ByVal txtProdDesc As String, ByVal txtProdClass As String, ByVal txtWarename As String, ByVal txtWareRoom As String, ByVal txtRoomLevel As String, ByVal ofd As OpenFileDialog)
        If txtProdName = "" Or txtProdDesc = "" Or txtProdClass = "" Or txtWarename = "" Or txtWareRoom = "" Or txtRoomLevel = "" Or ofd.FileName() = Nothing Then
            MsgBox("Please Fill up all fields")
        End If
    End Sub
    ' Call this function to remove the key from memory after it is used for security.

    Public Sub ZeroMemory(ByVal addr As IntPtr, ByVal size As Integer)
    End Sub

    ' Function to generate a 64-bit key.
    Function GenerateKey() As String
        ' Create an instance of a symmetric algorithm. The key and the IV are generated automatically.
        Dim desCrypto As DESCryptoServiceProvider = DESCryptoServiceProvider.Create()

        ' Use the automatically generated key for encryption. 
        Return ASCIIEncoding.ASCII.GetString(desCrypto.Key)

    End Function

    Public Sub EncryptFile(ByVal sInputFilename As String, _
                   ByVal sOutputFilename As String, _
                   ByVal sKey As String)

        Dim fsInput As New FileStream(sInputFilename, _
                                    FileMode.Open, FileAccess.Read)
        Dim fsEncrypted As New FileStream(sOutputFilename, _
                                    FileMode.Create, FileAccess.Write)

        Dim DES As New DESCryptoServiceProvider()

        'Set secret key for DES algorithm.
        'A 64-bit key and an IV are required for this provider.
        DES.Key = ASCIIEncoding.ASCII.GetBytes(sKey)

        'Set the initialization vector.
        DES.IV = ASCIIEncoding.ASCII.GetBytes(sKey)

        'Create the DES encryptor from this instance.
        Dim desencrypt As ICryptoTransform = DES.CreateEncryptor()
        'Create the crypto stream that transforms the file stream by using DES encryption.
        Dim cryptostream As New CryptoStream(fsEncrypted, _
                                            desencrypt, _
                                            CryptoStreamMode.Write)

        'Read the file text to the byte array.
        Dim bytearrayinput(fsInput.Length - 1) As Byte
        fsInput.Read(bytearrayinput, 0, bytearrayinput.Length)
        'Write out the DES encrypted file.
        cryptostream.Write(bytearrayinput, 0, bytearrayinput.Length)
        cryptostream.Close()
    End Sub

    Public Sub DecryptFile(ByVal sInputFilename As String, _
        ByVal sOutputFilename As String, _
        ByVal sKey As String)

        Dim DES As New DESCryptoServiceProvider()
        'A 64-bit key and an IV are required for this provider.
        'Set the secret key for the DES algorithm.
        DES.Key() = ASCIIEncoding.ASCII.GetBytes(sKey)
        'Set the initialization vector.
        DES.IV = ASCIIEncoding.ASCII.GetBytes(sKey)

        'Create the file stream to read the encrypted file back.
        Dim fsread As New FileStream(sInputFilename, FileMode.Open, FileAccess.Read)
        'Create the DES decryptor from the DES instance.
        Dim desdecrypt As ICryptoTransform = DES.CreateDecryptor()
        'Create the crypto stream set to read and to do a DES decryption transform on incoming bytes.
        Dim cryptostreamDecr As New CryptoStream(fsread, desdecrypt, CryptoStreamMode.Read)
        'Print out the contents of the decrypted file.
        Dim fsDecrypted As New StreamWriter(sOutputFilename)
        fsDecrypted.Write(New StreamReader(cryptostreamDecr).ReadToEnd)
        fsDecrypted.Flush()
        fsDecrypted.Close()
    End Sub

    Public Sub ResizePicture(ByVal pBox As PictureBox, ByVal img As Image)
        pBox.SizeMode = PictureBoxSizeMode.CenterImage
        Dim imageSize As Size = img.Size
        Dim lnewWidth As Integer, lnewHeight As Integer
        Dim lWidth As Integer = imageSize.Width
        Dim lHeight As Integer = imageSize.Height

        'If image Width > pictureBox Width, resize Width
        If lWidth > pBox.Width Then
            lnewWidth = pBox.Width                   'New Width = PBox Width
            lHeight = Convert.ToInt32(lHeight * (lnewWidth / lWidth)) 'Risize Height keeping proportions
        Else
            lnewWidth = lWidth                       'If not, keep the original Width value
        End If

        'If the image Height > The pictureBox Height, resize Height
        If lHeight > pBox.Height Then
            lnewHeight = pBox.Height              'New Height = PB Height
            lnewWidth = Convert.ToInt32(lnewWidth * (lnewHeight / lHeight))  'Risize Width keeping proportions
        Else
            lnewHeight = lHeight                            'If not, use the same value
        End If

        Dim lBitmap As Bitmap = New System.Drawing.Bitmap(lnewWidth, lnewHeight)
        Dim lGr As Graphics = System.Drawing.Graphics.FromImage(lBitmap)

        'Add resized to Picturebox, if you want it centered: In Design mode, Change SizeMode property to CenterImage
        lGr.DrawImage(img, 0, 0, lnewWidth, lnewHeight)
        pBox.Image = lBitmap

        lGr.Dispose()
        lGr = Nothing
    End Sub

End Module

