public class FlexTransition : MonoBehaviour // TypeDefIndex: 6824
{
	public FlexTransition.Definition[] Transitions; 
	private readonly List<int> _pendingIds; 
	private bool _currentState; 


	public void Start() { }

	public void SwitchState(bool enabled, bool animate) { }

	public void SwitchState(bool enabled) { }

	public void ToggleState() { }

	private static ref float Property(FlexElement element, FlexTransition.TransitionProperty property) { }

	public void .ctor() { }

}

public enum FlexTransition.TransitionProperty // TypeDefIndex: 6825
{
	public int value__; 
	public const FlexTransition.TransitionProperty PaddingLeft = 0;
	public const FlexTransition.TransitionProperty PaddingRight = 1;
	public const FlexTransition.TransitionProperty PaddingTop = 2;
	public const FlexTransition.TransitionProperty PaddingBottom = 3;
	public const FlexTransition.TransitionProperty Gap = 4;
	public const FlexTransition.TransitionProperty MinWidth = 5;
	public const FlexTransition.TransitionProperty MinHeight = 6;
	public const FlexTransition.TransitionProperty MaxWidth = 7;
	public const FlexTransition.TransitionProperty MaxHeight = 8;
	public const FlexTransition.TransitionProperty ScaleX = 100;
	public const FlexTransition.TransitionProperty ScaleY = 101;
	public const FlexTransition.TransitionProperty ImageColor = 102;
	public const FlexTransition.TransitionProperty TextColor = 103;
	public const FlexTransition.TransitionProperty CanvasAlpha = 104;

}

public struct FlexTransition.Definition // TypeDefIndex: 6826
{
	public FlexTransition.TransitionProperty Property; 
	public Object Object; 
	public float FromFloat; 
	public float ToFloat; 
	public Color FromColor; 
	public Color ToColor; 
	[MinAttribute] 
	public float Duration; 
	public LeanTweenType Ease; 

}

private sealed class FlexTransition.<>c__DisplayClass6_0 // TypeDefIndex: 6827
{
	public Image image; 
	public Color startValue; 
	public Color targetValue; 


	public void .ctor() { }

	internal void <SwitchState>b__2(float value) { }

}

private sealed class FlexTransition.<>c__DisplayClass6_1 // TypeDefIndex: 6828
{
	public TMP_Text text; 
	public Color startValue; 
	public Color targetValue; 


	public void .ctor() { }

	internal void <SwitchState>b__3(float value) { }

}

private sealed class FlexTransition.<>c__DisplayClass6_2 // TypeDefIndex: 6829
{
	public FlexElement element; 
	public FlexTransition.TransitionProperty property; 


	public void .ctor() { }

	internal void <SwitchState>b__4(float newValue, object _) { }

}

private sealed class FlexTransition.<>c // TypeDefIndex: 6830
{
	public static readonly FlexTransition.<>c <>9; 
	public static Action<float, object> <>9__6_0; 
	public static Action<float, object> <>9__6_1; 


	private static void .cctor() { }

	public void .ctor() { }

	internal void <SwitchState>b__6_0(float value, object obj) { }

	internal void <SwitchState>b__6_1(float value, object obj) { }

}

