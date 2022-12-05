public class TextTable // TypeDefIndex: 6610
{
	private List<TextTable.Row> rows;
	private List<TextTable.Column> columns;
	private StringBuilder builder;
	private string text;
	private string jsonText;
	private static Encoding utf8NoBom;


	public void Clear() { }

	public void AddColumns(string[] values) { }

	public void AddColumn(string title) { }

	public void AddRow(string[] values) { }

	public string ToJson() { }

	public override string ToString() { }

	private void MarkDirty() { }

	public void .ctor() { }

	private static void .cctor() { }

}

private class TextTable.Row // TypeDefIndex: 6611
{
	public string[] values;


	public void .ctor(string[] values) { }

}

private class TextTable.Column // TypeDefIndex: 6612
{
	public string title;
	public int width;


	public void .ctor(string title) { }

}

