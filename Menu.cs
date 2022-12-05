public class Menu : RustControl // TypeDefIndex: 7051
{
	public bool AllowFiltering;
	public int MaxResults;
	public Image Border;
	public Image Background;
	public Option[] Options;
	public RectTransform OptionCanvas;
	public RustInput FilterField;
	public Option SelectedOption;
	public Menu.ChangedEvent OnSelected;
	public Blocker Blocker;


	protected override void Awake() { }

	public void Build() { }

	private void OnOptionSelected(Option option) { }

	private IEnumerable<Option> GetOptions() { }

	internal void Popup(RectTransform source) { }

	private void RestrainToScreen() { }

	protected override void ApplyStyle(StyleAsset.Group s) { }

	public void .ctor() { }

	[CompilerGeneratedAttribute]
	private void <Awake>

}

public class Menu.ChangedEvent : UnityEvent<Option> // TypeDefIndex: 7052
{

	public void .ctor() { }

}

private sealed class Menu.<>c__DisplayClass12_0 // TypeDefIndex: 7053
{
	public Option option;
	public Menu <>4__this;


	public void .ctor() { }

	internal void <Build>

}

private sealed class Menu.<>c__DisplayClass14_0 // TypeDefIndex: 7054
{
	public string searchString;


	public void .ctor() { }

	internal bool <GetOptions>

}

private sealed class Menu.<>c // TypeDefIndex: 7055
{
	public static readonly Menu.<>c <>9;
	public static Func<Option, Option> <>9__14_0;


	private static void .cctor() { }

	public void .ctor() { }

	internal Option <GetOptions>

}

