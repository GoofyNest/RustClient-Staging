public class PercentFullStorageContainer : StorageContainer // TypeDefIndex: 9515
{	private float _clientPercentFull; // 0x3D0

	protected float ClientPercentFull { get; set; }


	public bool IsFull() { }

	public bool IsEmpty() { }

	protected virtual void OnPercentFullChanged(float newPercentFull) { }

	public float GetPercentFull() { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	protected float get_ClientPercentFull() { }

	protected void set_ClientPercentFull(float value) { }

	public void .ctor() { }

}

