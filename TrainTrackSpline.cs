public class TrainTrackSpline : WorldSpline // TypeDefIndex: 9774
{	// Fields
	[TooltipAttribute] // RVA: 0x97CB0 Offset: 0x970B0 VA: 0x180097CB0
	public bool isStation; // 0x40
	[TooltipAttribute] // RVA: 0x97DB0 Offset: 0x971B0 VA: 0x180097DB0
	public bool aboveGroundSpawn; // 0x41
	public bool useNewTangentCalc; // 0x42
	public int hierarchy; // 0x44

	// Methods

	// RVA: 0xA168A0 Offset: 0xA14EA0 VA: 0x180A168A0
	public void .ctor() { }

}

public enum TrainTrackSpline.TrackSelection // TypeDefIndex: 9775
{	// Fields
	public int value__; // 0x0
	public const TrainTrackSpline.TrackSelection Default = 0;
	public const TrainTrackSpline.TrackSelection Left = 1;
	public const TrainTrackSpline.TrackSelection Right = 2;

}

