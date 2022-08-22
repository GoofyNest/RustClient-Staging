public class TrainTrackSpline : WorldSpline // TypeDefIndex: 9774
{	// Fields
	[TooltipAttribute] // RVA: 0x97D40 Offset: 0x97140 VA: 0x180097D40
	public bool isStation; // 0x40
	[TooltipAttribute] // RVA: 0x97F30 Offset: 0x97330 VA: 0x180097F30
	public bool aboveGroundSpawn; // 0x41
	public int hierarchy; // 0x44

	// Methods

	// RVA: 0xA17050 Offset: 0xA15650 VA: 0x180A17050
	public void .ctor() { }

}

public enum TrainTrackSpline.TrackSelection // TypeDefIndex: 9775
{	// Fields
	public int value__; // 0x0
	public const TrainTrackSpline.TrackSelection Default = 0;
	public const TrainTrackSpline.TrackSelection Left = 1;
	public const TrainTrackSpline.TrackSelection Right = 2;

}

