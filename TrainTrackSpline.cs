public class TrainTrackSpline : WorldSpline // TypeDefIndex: 9774
{	[TooltipAttribute] // RVA: 0x97E70 Offset: 0x97270 VA: 0x180097E70
	public bool isStation; // 0x40
	[TooltipAttribute] // RVA: 0x98060 Offset: 0x97460 VA: 0x180098060
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

