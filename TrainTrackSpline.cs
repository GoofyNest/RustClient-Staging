public class TrainTrackSpline : WorldSpline // TypeDefIndex: 11526
{
	[TooltipAttribute]
	public bool isStation;
	[TooltipAttribute]
	public bool aboveGroundSpawn;
	public int hierarchy;


	public void .ctor() { }

}

public enum TrainTrackSpline.TrackSelection // TypeDefIndex: 11527
{
	public int value__;
	public const TrainTrackSpline.TrackSelection Default = 0;
	public const TrainTrackSpline.TrackSelection Left = 1;
	public const TrainTrackSpline.TrackSelection Right = 2;

}

