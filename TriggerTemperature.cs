public class TriggerTemperature : TriggerBase // TypeDefIndex: 10054
{
	public float Temperature; 
	public float triggerSize; 
	public float minSize; 
	public bool sunlightBlocker; 
	public float sunlightBlockAmount; 
	[RangeAttribute] 
	public float blockMinHour; 
	[RangeAttribute] 
	public float blockMaxHour; 


	private void OnValidate() { }

	public void .ctor() { }

}

