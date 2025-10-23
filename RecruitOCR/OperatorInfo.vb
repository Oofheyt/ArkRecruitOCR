Imports System.Text
Imports Newtonsoft.Json
Imports RecruitOCR.RecruitMain

Public Class OperatorInfo
    Public Property OperatorInternalId As String

    Private Sub OperatorInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If String.IsNullOrEmpty(OperatorInternalId) Then
            MessageBox.Show("No operator ID provided.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Close()
            Return
        End If

        Try

            Dim jsonText As String = Encoding.UTF8.GetString(My.Resources.operators_with_ids)
            Dim fileObj = JsonConvert.DeserializeObject(Of OperatorFile)(jsonText)
            Dim op = fileObj.Operators.FirstOrDefault(Function(o) o.Internalid.Equals(OperatorInternalId, StringComparison.OrdinalIgnoreCase))

            If op Is Nothing Then
                MessageBox.Show("Operator not found: " & OperatorInternalId, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Close()
                Return
            End If

            LabelName.Text = op.Name
            LabelRarity.Text = ""
            For i As Integer = 0 To op.Rarity - 1
                LabelRarity.Text = LabelRarity.Text & "★"
            Next
            LabelClass.Text = op.Role
            LabelPosition.Text = op.Position
            LabelTrait.Text = op.Trait
            LabelDescription.Text = op.Description
            LabelDescriptionTagLine.Text = op.DescriptionTagLine
            LabelBranch.Text = op.ClassBranch
            LabelNation.Text = op.Nation
            LabelGroup.Text = op.Group
            LabelTeam.Text = op.Team
            LabelTags.Text = String.Join(", ", op.TagList)

            If My.Resources.ResourceManager.GetObject(op.Internalid) IsNot Nothing Then
                PictureBoxPortrait.Image = CType(My.Resources.ResourceManager.GetObject(op.Internalid), Image)
            Else
                'PictureBoxPortrait.Image = Nothing
            End If

        Catch ex As Exception
            MessageBox.Show("Failed to load operator data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Close()
        End Try
    End Sub
End Class