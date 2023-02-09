# ScrollWriter
Enables character by character writing in a console from string text with configurable time period between characters drawn

Designed for Visual Basic and C# with .NET Framework 4.0

## Contains the following features:
- SWriter.Write(string text, int waitPeriod = 50)
-> Writes each character in the input text individually with a delay set by waitPeriod between characters. Does not create a new line after finishing.

- SWriter.WriteLine(string text, int waitPeriod = 50)
-> Same as Write but instead creates a new line after finishing.

- SWriter.WriteVertical(string text, int waitPeriod = 50)
-> Same as Write but writes each character in a new line. Does not create a new line after the last character.

- SWriter.WriteVerticalN(string text, int waitPeriod = 50)
-> same as WriteVertical but creates new line after last character.
## Planned Feature(s):
- Spreadsheet-alike write using arrays
- (Colors)?
