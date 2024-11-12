Public Class TermParser
    ' Structure to hold the parsed values
    Public Structure ParsedTerm
        Public Number As Integer
        Public Unit As String
    End Structure

    ' Main function to parse the terms
    Public Shared Function ParseTerms(input As String) As List(Of ParsedTerm)
        Dim result As New List(Of ParsedTerm)

        ' Split by comma if multiple terms exist
        Dim terms = input.Split(","c).Select(Function(t) t.Trim()).ToList()

        For Each term In terms
            ' Extract number using regular expression
            Dim numberMatch = System.Text.RegularExpressions.Regex.Match(term, "\d+")

            If numberMatch.Success Then
                Dim parsedTerm As New ParsedTerm

                ' Get the number
                parsedTerm.Number = Integer.Parse(numberMatch.Value)

                ' Get the unit (remove the number and trim)
                parsedTerm.Unit = term.Replace(numberMatch.Value, "").Trim().ToLower()

                ' Clean up the unit (remove 's' if plural)
                If parsedTerm.Unit.EndsWith("s") Then
                    parsedTerm.Unit = parsedTerm.Unit.TrimEnd("s"c)
                End If

                result.Add(parsedTerm)
            End If
        Next

        Return result
    End Function
End Class