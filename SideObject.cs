public class SideObject : ScriptableObject // TypeDefIndex: 7162
{
	public string version; 
	public string name; 
	public double id; 
	public double timestamp; 
	public int objectType; 
	public string gameobjectGUID; 
	public string textureGUID; 
	public float m_distance; 
	public float uvx; 
	public float uvy; 
	public int position; 
	public float splinePosition; 
	public int selectedRotation; 
	public float randomYAxisMinRotation; 
	public float randomYAxisMaxRotation; 
	public List<Vector2> nodeList; 
	public List<float> uvs; 
	public List<float> uvDistances; 
	public bool clampUVs; 
	public bool clampUVY; 
	public float clampUVYValue; 
	public float totalDistance; 
	public bool reverseUVs; 
	public bool terrainUVs; 
	public List<bool> snapList; 
	public List<float> snapWeightList; 
	public List<Color> colorList; 
	public string gameobjectStartGUID; 
	public string gameobjectEndGUID; 
	public int align; 
	public int alignPoint; 
	public bool weld; 
	public bool combine; 
	public bool combineInstantiated; 
	public bool markerActive; 
	public int uvType; 
	public float uv; 
	public bool randomObjects; 
	public float forwardStartOffset; 
	public float sidewaysOffset; 
	public float density; 
	public string goPath; 
	public string startPath; 
	public string endPath; 
	public string texturePath; 
	public int terrainTree; 
	public float minScale; 
	public float maxScale; 
	public bool childOrderActive; 
	public int childOrder; 
	public bool meshBoundsAlignment; 
	public float xPosition; 
	public float xPosition2; 
	public int relativeTo; 
	public float yPosition; 
	public float yRotation; 
	public float oldSidwaysDistance; 
	public int sidewaysDistanceUpdate; 
	public float uvYRound; 
	public bool adjustUV; 
	public bool collider; 
	public bool boxcollider; 
	public bool tangents; 
	public GameObject sourceObject; 
	public bool flipMesh; 
	public GameObject startObject; 
	public GameObject endObject; 
	public GameObject connectionObject; 
	public Material material; 
	public List<ERMesh> meshObjects; 
	public Vector2 boxSize; 
	public Vector2 boxOffset; 
	public bool includeStartSegment; 
	public float startSegmentOffset; 
	public bool includeStartEdgeTris; 
	public bool includeEndSegment; 
	public float endSegmentOffset; 
	public bool includeEndEdgeTris; 
	public bool adjustToRoadWidth; 
	public float xOffset; 
	public float startOffset; 
	public float endOffset; 
	public float defaultStartOffset; 
	public float defaultEndOffset; 
	public float totalZDistance; 
	public float middleZDistance; 
	public float startZDistance; 
	public float endZDistance; 
	public float minStartZ; 
	public float maxStartZ; 
	public float minMiddleZ; 
	public float maxMiddleZ; 
	public float minEndZ; 
	public float maxEndZ; 
	public bool smoothStart; 
	public bool smoothMiddle; 
	public bool smoothEnd; 
	public GameObject targetObject; 
	public bool bridgeObject; 
	public bool tunnelObject; 
	public bool snapToTerrain; 
	public int layer; 
	public bool deformationObject; 
	public bool isStatic; 
	public bool castShadows; 
	public bool scaleToRoad; 
	public bool splitInBatches; 
	public List<GameObject> instantiatedObjects; 
	public int maxVertices; 
	public bool doTestmesh; 
	public Vector3 testMeshPos; 
	public Vector3 randomRotation; 
	public float randomMinRotation; 
	public float randomMaxRotation; 
	public float minRandomRotationDistance; 
	public float maxRandomRotationDistance; 
	public float randomXPosition; 
	public float randomMinXPosition; 
	public float randomMaxXPosition; 
	public float minRandomXPositionDistance; 
	public float maxRandomXPositionDistance; 
	public Vector3 boxColliderScale; 
	public float randomYPosition; 
	public float randomMinYPosition; 
	public float randomMaxYPosition; 
	public float minRandomYPositionDistance; 
	public float maxRandomYPositionDistance; 
	public bool indentController; 
	public bool excludeTerrainSplats; 
	public float x1; 
	public float x2; 
	public float xf1; 
	public float xf2; 
	public float y1; 
	public float bridgeHeight; 
	public int markerSplineController; 
	public float bridgeLength; 
	public float deformationOffset; 
	public float markerIndent; 
	public float markerSurrounding; 
	public Vector3 scale; 
	public float indentExt; 
	public int category; 
	public Texture2D densityMap; 
	public float densitySize; 
	public float densitySize2; 
	public float densityStrength; 
	public float densityStrength2; 
	public float terrainNormal; 
	public float terrainNormal2; 
	public List<ERChildsSO> childObjects; 
	public bool autoGenerate; 
	public float heightThreshold; 
	public float autogenerateStartOffset; 
	public float autogenerateEndOffset; 
	public bool snapIndents; 
	public float snapIndentWidth; 
	public bool cutHoles; 
	public float innerStartOffset; 
	public float innerEndOffset; 
	public bool ignoredForRetainingWalls; 
	public float heightMaxThreshold; 
	public float heightMaxStartThreshold; 
	public float heightMaxEndThreshold; 
	public float xThresholdDistance; 
	public float angleThreshold; 
	public int connectionRatio; 
	public bool retainingWall; 
	public int surroundingControl; 
	public int indentControl; 
	public List<Vector2> nodeListMirrored; 
	public List<float> uvsMirrored; 
	public List<float> snapWeightListMirrored; 
	public List<Color> colorListMirrored; 
	public bool hasVertexColors; 
	public float deformationOffsetForward; 
	public float deformationOffsetSideways; 
	public int connectionObjectRotation; 
	public bool subMesh; 
	public bool acceptBarriers; 
	public bool activeOnBridges; 
	public bool dualSided; 
	public int mirrorType; 
	public bool snapVertexColors; 
	public float minSnapRange; 
	public float maxSnapRange; 
	public bool clampUV4; 
	public float geoStartOffset; 
	public float geoEndOffset; 
	public float startOverlapOffset; 
	public float endOverlapOffset; 
	public int lodLevels; 
	public List<bool> hardEdge; 
	public float hardEdgePadding; 
	public bool startEndCaps; 
	public List<Vector2> endCapUVs; 
	public List<Vector2> startCapUVs; 
	public List<int> startCapTris; 
	public List<int> startCapTrisMirrored; 
	public Vector2 startCapUVOffset; 
	public Vector2 endCapUVOffset; 
	public float startCapUVScale; 
	public float endCapUVScale; 
	public float startCapUVRotation; 
	public float endCapUVRotation; 
	public bool namedChilds; 
	public bool startSection; 
	public bool endSection; 
	public bool stepDown; 
	public bool stepUp; 
	public float stepDistance; 
	public float startDirZOffset; 
	public float endDirZOffset; 
	public bool buildOtherSideObject1; 
	public double defaultOtherSoId1; 
	public bool buildOtherSideObject2; 
	public double defaultOtherSoId2; 
	public List<double> buildOtherSideObjects; 
	public bool averageDistance; 
	public bool randomUVx; 
	public bool isUsedAsChild; 


	public void SetSideObject(int count, int scategory) { }

	public void UpdateTimeStamp() { }

	public void OOCCDCDOQC() { }

	public void OQOQOQOODC() { }

	public void SetMaxVertices() { }

	public static bool CheckSOChildActive(List<ERSOSection> sections, SideObject so) { }

	public void OOOCDOQOOC(bool updateTimeStamp) { }

	public void OQDODCOODC() { }

	public void OQDDDDOOQD(Vector3 m_testMeshPos, bool updateTimeStamp) { }

	private void OQOODQQQQC(List<Vector3> vecs, float startDistance, List<Vector3> vecs1, float endDistance, ref List<int> startArray, ref List<int> endArray, int section) { }

	private float OQQDDOCDDQ(List<GameObject> goObjects, bool rotate180) { }

	private bool HasMissingData(ERMesh meshData, ERMesh meshData2, int ignore) { }

	public void OODOOOQQCO(SideObject so) { }

	public void OCDOCDQQQO(SideObjectLog so) { }

	public void Clear() { }

	public void .ctor() { }

}

