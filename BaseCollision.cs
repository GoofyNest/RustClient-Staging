public class BaseCollision : MonoBehaviour, IClientComponent // TypeDefIndex: 10928
{
	public BaseEntity Owner; 
	public Model model; 


	public virtual void TraceTest(HitTest test, List<TraceInfo> hits) { }

	public void .ctor() { }

}

