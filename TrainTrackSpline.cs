public class TrainTrackSpline : WorldSpline // TypeDefIndex: 9774
{	[TooltipAttribute] // RVA: 0x974F0 Offset: 0x968F0 VA: 0x1800974F0
	public bool isStation; // 0x40
	[TooltipAttribute] // RVA: 0x976F0 Offset: 0x96AF0 VA: 0x1800976F0
	public bool aboveGroundSpawn; // 0x41
	public int hierarchy; // 0x44


	public void .ctor() { }

}

public enum TrainTrackSpline.TrackSelection // TypeDefIndex: 9775
{	public int value__; // 0x0
	public const TrainTrackSpline.TrackSelection Default = 0;
	public const TrainTrackSpline.TrackSelection Left = 1;
	public const TrainTrackSpline.TrackSelection Right = 2;

}

