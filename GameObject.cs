public sealed class GameObject : Object // TypeDefIndex: 3515
{
[UsedByNativeCodeAttribute] // RVA: 0xBC0E0 Offset: 0xBB4E0 VA: 0x1800BC0E0
[ExcludeFromPresetAttribute] // RVA: 0xBC0E0 Offset: 0xBB4E0 VA: 0x1800BC0E0
[NativeHeaderAttribute] // RVA: 0xBC0E0 Offset: 0xBB4E0 VA: 0x1800BC0E0
public sealed class GameObject : Object // TypeDefIndex: 3515
	public Transform transform { get; }
	public int layer { get; set; }
	public bool activeSelf { get; }
	public bool activeInHierarchy { get; }
	public bool isStatic { get; set; }
	public string tag { get; set; }
	public GameObject gameObject { get; }


	[FreeFunctionAttribute] // RVA: 0xBC400 Offset: 0xBB800 VA: 0x1800BC400
	public static GameObject CreatePrimitive(PrimitiveType type) { }

	public T GetComponent<T>() { }
	/* GenericInstMethod :
	|
	|-GameObject.GetComponent<AdminExistingSellOrder>
	|-GameObject.GetComponent<AmbienceEmitter>
	|-GameObject.GetComponent<AttackEntity>
	|-GameObject.GetComponent<BaseBulb>
	|-GameObject.GetComponent<BaseCollision>
	|-GameObject.GetComponent<BaseEntity>
	|-GameObject.GetComponent<BaseMelee>
	|-GameObject.GetComponent<BaseMeshPaintable>
	|-GameObject.GetComponent<BaseMovement>
	|-GameObject.GetComponent<BaseProjectile>
	|-GameObject.GetComponent<BaseViewModel>
	|-GameObject.GetComponent<BlueprintButton>
	|-GameObject.GetComponent<BobberPreview>
	|-GameObject.GetComponent<BranchConfig>
	|-GameObject.GetComponent<BuildingPrivlidge>
	|-GameObject.GetComponent<CardTableUI>
	|-GameObject.GetComponent<ChangeSignText>
	|-GameObject.GetComponent<ChatEntry>
	|-GameObject.GetComponent<ClientIOLine>
	|-GameObject.GetComponent<ColliderInfo>
	|-GameObject.GetComponent<CommunityEntity.FadeOut>
	|-GameObject.GetComponent<ComputerMenu>
	|-GameObject.GetComponent<ConditionalGibbable>
	|-GameObject.GetComponent<ConstructionSkin>
	|-GameObject.GetComponent<CounterConfig>
	|-GameObject.GetComponent<CraftingQueueIcon>
	|-GameObject.GetComponent<CullingVolume>
	|-GameObject.GetComponent<DemoItem>
	|-GameObject.GetComponent<DemoShotEntry>
	|-GameObject.GetComponent<DemoShotListFolderWidget>
	|-GameObject.GetComponent<DropMe>
	|-GameObject.GetComponent<ERSurfaceScript>
	|-GameObject.GetComponent<ERCrossingPrefabs>
	|-GameObject.GetComponent<ERCrossings>
	|-GameObject.GetComponent<ERIConnector>
	|-GameObject.GetComponent<ERModularBase>
	|-GameObject.GetComponent<ERModularRoad>
	|-GameObject.GetComponent<ERRoundabouts>
	|-GameObject.GetComponent<ERSideObjectInstance>
	|-GameObject.GetComponent<ERSideObjectLog>
	|-GameObject.GetComponent<ERTerrain>
	|-GameObject.GetComponent<EffectParentToWeaponBone>
	|-GameObject.GetComponent<EntityDebug>
	|-GameObject.GetComponent<EnvironmentFish>
	|-GameObject.GetComponent<EnvironmentVolume>
	|-GameObject.GetComponent<SkeletonSkin>
	|-GameObject.GetComponent<VirtualScroll.IDataSource>
	|-GameObject.GetComponent<FavouriteRadioStation>
	|-GameObject.GetComponent<FireworkShell>
	|-GameObject.GetComponent<FoliageGridBatch>
	|-GameObject.GetComponent<FootstepSound>
	|-GameObject.GetComponent<FrequencyConfig>
	|-GameObject.GetComponent<Gib>
	|-GameObject.GetComponent<Gibbable>
	|-GameObject.GetComponent<GrowableEntity>
	|-GameObject.GetComponent<HeldEntity>
	|-GameObject.GetComponent<IEffectRecycle>
	|-GameObject.GetComponent<INotifyLOD>
	|-GameObject.GetComponent<IOEntity>
	|-GameObject.GetComponent<IconSkin>
	|-GameObject.GetComponent<IdentifierConfig>
	|-GameObject.GetComponent<ImageEffectComposite>
	|-GameObject.GetComponent<ImageRenderController>
	|-GameObject.GetComponent<ImpostorShadows>
	|-GameObject.GetComponent<IronSightOverride>
	|-GameObject.GetComponent<ItemBlueprint>
	|-GameObject.GetComponent<ItemDefinition>
	|-GameObject.GetComponent<ItemOptionButton>
	|-GameObject.GetComponent<ItemPickupNotice>
	|-GameObject.GetComponent<ItemStoreCartItem>
	|-GameObject.GetComponent<ItemStoreItem>
	|-GameObject.GetComponent<KeyCodeEntry>
	|-GameObject.GetComponent<KeyframeWidget>
	|-GameObject.GetComponent<LifeInfographicStatDynamicRow>
	|-GameObject.GetComponent<LifeInfographicStatWeapon>
	|-GameObject.GetComponent<MainCamera>
	|-GameObject.GetComponent<MapLayerRenderer>
	|-GameObject.GetComponent<MaterialSwap>
	|-GameObject.GetComponent<MaxSpawnDistance>
	|-GameObject.GetComponent<MedicalTool>
	|-GameObject.GetComponent<MeshRendererBatch>
	|-GameObject.GetComponent<MissionMapMarker>
	|-GameObject.GetComponent<Model>
	|-GameObject.GetComponent<MonumentMarker>
	|-GameObject.GetComponent<NeedsCursor>
	|-GameObject.GetComponent<NeedsKeyboard>
	|-GameObject.GetComponent<ObjectMotionVectorFix>
	|-GameObject.GetComponent<PhoneDialler>
	|-GameObject.GetComponent<PhoneDirectoryEntry>
	|-GameObject.GetComponent<PhysicsEffects>
	|-GameObject.GetComponent<PickAFriend>
	|-GameObject.GetComponent<PieOption>
	|-GameObject.GetComponent<PlantSkin>
	|-GameObject.GetComponent<PlayerModel>
	|-GameObject.GetComponent<PlayerWalkMovement>
	|-GameObject.GetComponent<PointOfInterestMapMarker>
	|-GameObject.GetComponent<Poolable>
	|-GameObject.GetComponent<PowerLineWireConnectionHelper>
	|-GameObject.GetComponent<PrefabParameters>
	|-GameObject.GetComponent<Projectile>
	|-GameObject.GetComponent<ProjectileWeaponMod>
	|-GameObject.GetComponent<QuickCraftButton>
	|-GameObject.GetComponent<RCBookmarkEntry>
	|-GameObject.GetComponent<RadioDialog>
	|-GameObject.GetComponent<Ragdoll>
	|-GameObject.GetComponent<RecordingBars>
	|-GameObject.GetComponent<RenameSleepingBag>
	|-GameObject.GetComponent<ReskinEffect>
	|-GameObject.GetComponent<RidableHorse>
	|-GameObject.GetComponent<IEntity>
	|-GameObject.GetComponent<PropRenderer>
	|-GameObject.GetComponent<FileDialog>
	|-GameObject.GetComponent<FileListElement>
	|-GameObject.GetComponent<RustButton>
	|-GameObject.GetComponent<RustText>
	|-GameObject.GetComponent<ServerAdminServerInfo>
	|-GameObject.GetComponent<SteamInventoryItem>
	|-GameObject.GetComponent<WorkshopItemButton>
	|-GameObject.GetComponent<WorkshopSkin>
	|-GameObject.GetComponent<SellOrderEntry>
	|-GameObject.GetComponent<ServerBrowserItem>
	|-GameObject.GetComponent<ServerHistoryItem>
	|-GameObject.GetComponent<ServerProjectile>
	|-GameObject.GetComponent<SetupAppNotification>
	|-GameObject.GetComponent<SlotMachinePayoutWidget>
	|-GameObject.GetComponent<Sound>
	|-GameObject.GetComponent<SoundLightDialog>
	|-GameObject.GetComponent<SoundPlayer>
	|-GameObject.GetComponent<SoundSource>
	|-GameObject.GetComponent<SprayCanSkinSelect>
	|-GameObject.GetComponent<SteamUserButton>
	|-GameObject.GetComponent<TMP_InputField>
	|-GameObject.GetComponent<TMP_SubMesh>
	|-GameObject.GetComponent<TMP_Text>
	|-GameObject.GetComponent<TerrainGenerator>
	|-GameObject.GetComponent<TerrainMeta>
	|-GameObject.GetComponent<ThrownWeapon>
	|-GameObject.GetComponent<TimedExplosive>
	|-GameObject.GetComponent<TimerConfig>
	|-GameObject.GetComponent<ToggleHUDLayer>
	|-GameObject.GetComponent<UIChatPopup>
	|-GameObject.GetComponent<UIEscapeCapture>
	|-GameObject.GetComponent<UIFireworkDesigner>
	|-GameObject.GetComponent<UIFireworkStar>
	|-GameObject.GetComponent<UIMapGenericRadius>
	|-GameObject.GetComponent<UIMapVendingMachineMarker>
	|-GameObject.GetComponent<UIMapVendingMachineMarkerCluster>
	|-GameObject.GetComponent<UIMarketSearchStore>
	|-GameObject.GetComponent<UIMixingTableItem>
	|-GameObject.GetComponent<UIPaintableImage>
	|-GameObject.GetComponent<UnderwearIcon>
	|-GameObject.GetComponent<NavMeshAgent>
	|-GameObject.GetComponent<NavMeshObstacle>
	|-GameObject.GetComponent<AudioSource>
	|-GameObject.GetComponent<BoxCollider>
	|-GameObject.GetComponent<Camera>
	|-GameObject.GetComponent<Canvas>
	|-GameObject.GetComponent<CanvasGroup>
	|-GameObject.GetComponent<CanvasRenderer>
	|-GameObject.GetComponent<Collider>
	|-GameObject.GetComponent<LODGroup>
	|-GameObject.GetComponent<Light>
	|-GameObject.GetComponent<MeshCollider>
	|-GameObject.GetComponent<MeshFilter>
	|-GameObject.GetComponent<MeshRenderer>
	|-GameObject.GetComponent<ParticleSystem>
	|-GameObject.GetComponent<RectTransform>
	|-GameObject.GetComponent<ReflectionProbe>
	|-GameObject.GetComponent<Renderer>
	|-GameObject.GetComponent<Rigidbody>
	|-GameObject.GetComponent<SpriteRenderer>
	|-GameObject.GetComponent<Terrain>
	|-GameObject.GetComponent<TerrainCollider>
	|-GameObject.GetComponent<Transform>
	|-GameObject.GetComponent<Button>
	|-GameObject.GetComponent<Dropdown>
	|-GameObject.GetComponent<Image>
	|-GameObject.GetComponent<InputField>
	|-GameObject.GetComponent<Mask>
	|-GameObject.GetComponent<ScrollRect>
	|-GameObject.GetComponent<Scrollbar>
	|-GameObject.GetComponent<Slider>
	|-GameObject.GetComponent<Text>
	|-GameObject.GetComponent<Toggle>
	|-GameObject.GetComponent<ToggleGroup>
	|-GameObject.GetComponent<VendingPanelAdmin>
	|-GameObject.GetComponent<ViewmodelClothing>
	|-GameObject.GetComponent<VoicemailEntry>
	|-GameObject.GetComponent<Wearable>
	|-GameObject.GetComponent<WearableHolsterOffset>
	|-GameObject.GetComponent<object>
	*/

	[FreeFunctionAttribute] // RVA: 0xBC510 Offset: 0xBB910 VA: 0x1800BC510
	[TypeInferenceRuleAttribute] // RVA: 0xBC510 Offset: 0xBB910 VA: 0x1800BC510
	public Component GetComponent(Type type) { }

	[FreeFunctionAttribute] // RVA: 0xBC6E0 Offset: 0xBBAE0 VA: 0x1800BC6E0
	[NativeWritableSelfAttribute] // RVA: 0xBC6E0 Offset: 0xBBAE0 VA: 0x1800BC6E0
	internal void GetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue) { }

	[FreeFunctionAttribute] // RVA: 0xBDC40 Offset: 0xBD040 VA: 0x1800BDC40
	[TypeInferenceRuleAttribute] // RVA: 0xBDC40 Offset: 0xBD040 VA: 0x1800BDC40
	public Component GetComponentInChildren(Type type, bool includeInactive) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public T GetComponentInChildren<T>() { }
	/* GenericInstMethod :
	|
	|-GameObject.GetComponentInChildren<AnimationEvents>
	|-GameObject.GetComponentInChildren<DungeonGridLink>
	|-GameObject.GetComponentInChildren<DungeonVolume>
	|-GameObject.GetComponentInChildren<ERSurfaceScript>
	|-GameObject.GetComponentInChildren<OQQCCQCDQQ>
	|-GameObject.GetComponentInChildren<ItemButtonTools>
	|-GameObject.GetComponentInChildren<LadderMinMountHeight>
	|-GameObject.GetComponentInChildren<PaintableItem>
	|-GameObject.GetComponentInChildren<ProceduralObject>
	|-GameObject.GetComponentInChildren<HttpImage>
	|-GameObject.GetComponentInChildren<TextMeshProUGUI>
	|-GameObject.GetComponentInChildren<TooltipContainer>
	|-GameObject.GetComponentInChildren<LODGroup>
	|-GameObject.GetComponentInChildren<LineRenderer>
	|-GameObject.GetComponentInChildren<Rigidbody>
	|-GameObject.GetComponentInChildren<Button>
	|-GameObject.GetComponentInChildren<Dropdown.DropdownItem>
	|-GameObject.GetComponentInChildren<Text>
	|-GameObject.GetComponentInChildren<object>
	*/

	public T GetComponentInChildren<T>(bool includeInactive) { }
	/* GenericInstMethod :
	|
	|-GameObject.GetComponentInChildren<Text>
	|-GameObject.GetComponentInChildren<object>
	*/

	[FreeFunctionAttribute] // RVA: 0xBDF00 Offset: 0xBD300 VA: 0x1800BDF00
	[TypeInferenceRuleAttribute] // RVA: 0xBDF00 Offset: 0xBD300 VA: 0x1800BDF00
	public Component GetComponentInParent(Type type) { }

	public T GetComponentInParent<T>() { }
	/* GenericInstMethod :
	|
	|-GameObject.GetComponentInParent<BaseEntity>
	|-GameObject.GetComponentInParent<BaseViewModel>
	|-GameObject.GetComponentInParent<DropMe>
	|-GameObject.GetComponentInParent<IProvider>
	|-GameObject.GetComponentInParent<Model>
	|-GameObject.GetComponentInParent<Poolable>
	|-GameObject.GetComponentInParent<Ragdoll>
	|-GameObject.GetComponentInParent<RustControl>
	|-GameObject.GetComponentInParent<SoundSource>
	|-GameObject.GetComponentInParent<IPointerDownHandler>
	|-GameObject.GetComponentInParent<ISubmitHandler>
	|-GameObject.GetComponentInParent<object>
	*/

	[FreeFunctionAttribute] // RVA: 0xBE090 Offset: 0xBD490 VA: 0x1800BE090
	private Array GetComponentsInternal(Type type, bool useSearchTypeAsArrayReturnType, bool recursive, bool includeInactive, bool reverse, object resultList) { }

	public Component[] GetComponents(Type type) { }

	public T[] GetComponents<T>() { }
	/* GenericInstMethod :
	|
	|-GameObject.GetComponents<ConstructionGrade>
	|-GameObject.GetComponents<Component>
	|-GameObject.GetComponents<Graphic>
	|-GameObject.GetComponents<object>
	*/

	public void GetComponents<T>(List<T> results) { }
	/* GenericInstMethod :
	|
	|-GameObject.GetComponents<DecalRecycle>
	|-GameObject.GetComponents<IOnParentDestroying>
	|-GameObject.GetComponents<IOnParentSpawning>
	|-GameObject.GetComponents<IOnPostNetworkUpdate>
	|-GameObject.GetComponents<IOnSendNetworkUpdate>
	|-GameObject.GetComponents<RendererBatch>
	|-GameObject.GetComponents<object>
	|-GameObject.GetComponents<Component>
	*/

	[ExcludeFromDocsAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public Component[] GetComponentsInChildren(Type type) { }

	public Component[] GetComponentsInChildren(Type type, bool includeInactive) { }

	public T[] GetComponentsInChildren<T>(bool includeInactive) { }
	/* GenericInstMethod :
	|
	|-GameObject.GetComponentsInChildren<BlueprintCategoryButton>
	|-GameObject.GetComponentsInChildren<CraftingQueueIcon>
	|-GameObject.GetComponentsInChildren<SingletonComponent>
	|-GameObject.GetComponentsInChildren<TerrainPathConnect>
	|-GameObject.GetComponentsInChildren<Collider>
	|-GameObject.GetComponentsInChildren<Component>
	|-GameObject.GetComponentsInChildren<LODGroup>
	|-GameObject.GetComponentsInChildren<MonoBehaviour>
	|-GameObject.GetComponentsInChildren<ParticleSystem>
	|-GameObject.GetComponentsInChildren<Renderer>
	|-GameObject.GetComponentsInChildren<Rigidbody>
	|-GameObject.GetComponentsInChildren<Image>
	|-GameObject.GetComponentsInChildren<Text>
	|-GameObject.GetComponentsInChildren<Toggle>
	|-GameObject.GetComponentsInChildren<object>
	*/

	public void GetComponentsInChildren<T>(bool includeInactive, List<T> results) { }
	/* GenericInstMethod :
	|
	|-GameObject.GetComponentsInChildren<IEffect>
	|-GameObject.GetComponentsInChildren<IItemSetup>
	|-GameObject.GetComponentsInChildren<IItemUpdate>
	|-GameObject.GetComponentsInChildren<MaterialReplacement>
	|-GameObject.GetComponentsInChildren<MorphCache>
	|-GameObject.GetComponentsInChildren<object>
	|-GameObject.GetComponentsInChildren<MeshRenderer>
	|-GameObject.GetComponentsInChildren<ParticleSystem>
	|-GameObject.GetComponentsInChildren<Renderer>
	|-GameObject.GetComponentsInChildren<SkinnedMeshRenderer>
	*/

	public T[] GetComponentsInChildren<T>() { }
	/* GenericInstMethod :
	|
	|-GameObject.GetComponentsInChildren<ConditionalGibbable>
	|-GameObject.GetComponentsInChildren<ERSurfaceScript>
	|-GameObject.GetComponentsInChildren<ERConnectionParent>
	|-GameObject.GetComponentsInChildren<ERCrossingPrefabs>
	|-GameObject.GetComponentsInChildren<ERCrossings>
	|-GameObject.GetComponentsInChildren<ERModularRoad>
	|-GameObject.GetComponentsInChildren<ERPrefabInstance>
	|-GameObject.GetComponentsInChildren<ERRoadNetworkObject>
	|-GameObject.GetComponentsInChildren<ERRoundabouts>
	|-GameObject.GetComponentsInChildren<ERSideObjectInstance>
	|-GameObject.GetComponentsInChildren<ERSideObjectSection>
	|-GameObject.GetComponentsInChildren<EffectRecycle>
	|-GameObject.GetComponentsInChildren<MeshFilter>
	|-GameObject.GetComponentsInChildren<ParticleSystem>
	|-GameObject.GetComponentsInChildren<Renderer>
	|-GameObject.GetComponentsInChildren<Toggle>
	|-GameObject.GetComponentsInChildren<object>
	*/

	public void GetComponentsInChildren<T>(List<T> results) { }
	/* GenericInstMethod :
	|
	|-GameObject.GetComponentsInChildren<DecalRecycle>
	|-GameObject.GetComponentsInChildren<EffectRecycle>
	|-GameObject.GetComponentsInChildren<IOnParentDestroying>
	|-GameObject.GetComponentsInChildren<IOnParentSpawning>
	|-GameObject.GetComponentsInChildren<IOnPostNetworkUpdate>
	|-GameObject.GetComponentsInChildren<IOnSendNetworkUpdate>
	|-GameObject.GetComponentsInChildren<LODComponent>
	|-GameObject.GetComponentsInChildren<RendererBatch>
	|-GameObject.GetComponentsInChildren<object>
	|-GameObject.GetComponentsInChildren<LODGroup>
	|-GameObject.GetComponentsInChildren<MeshRenderer>
	*/

	public void GetComponentsInParent<T>(bool includeInactive, List<T> results) { }
	/* GenericInstMethod :
	|
	|-GameObject.GetComponentsInParent<object>
	|-GameObject.GetComponentsInParent<Canvas>
	|-GameObject.GetComponentsInParent<RectMask2D>
	*/

	public T[] GetComponentsInParent<T>(bool includeInactive) { }
	/* GenericInstMethod :
	|
	|-GameObject.GetComponentsInParent<object>
	*/

	public bool TryGetComponent<T>(out T component) { }
	/* GenericInstMethod :
	|
	|-GameObject.TryGetComponent<BaseEntity>
	|-GameObject.TryGetComponent<ICustomMaterialReplacer>
	|-GameObject.TryGetComponent<INotifyEntityTrigger>
	|-GameObject.TryGetComponent<INotifyTrigger>
	|-GameObject.TryGetComponent<PatternFireworkStar>
	|-GameObject.TryGetComponent<Ragdoll>
	|-GameObject.TryGetComponent<RendererInfo>
	|-GameObject.TryGetComponent<ServerAdminUGCEntryStub>
	|-GameObject.TryGetComponent<SteamUserButton>
	|-GameObject.TryGetComponent<object>
	|-GameObject.TryGetComponent<ThrownWeapon>
	|-GameObject.TryGetComponent<MeshCollider>
	|-GameObject.TryGetComponent<MeshFilter>
	|-GameObject.TryGetComponent<SkinnedMeshRenderer>
	|-GameObject.TryGetComponent<Button>
	|-GameObject.TryGetComponent<GridLayoutGroup>
	|-GameObject.TryGetComponent<Image>
	|-GameObject.TryGetComponent<Wearable>
	*/

	[FreeFunctionAttribute] // RVA: 0xBE430 Offset: 0xBD830 VA: 0x1800BE430
	[NativeWritableSelfAttribute] // RVA: 0xBE430 Offset: 0xBD830 VA: 0x1800BE430
	internal void TryGetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue) { }

	public void SendMessage(string methodName, SendMessageOptions options) { }

	public void BroadcastMessage(string methodName, SendMessageOptions options) { }

	[FreeFunctionAttribute] // RVA: 0xBE520 Offset: 0xBD920 VA: 0x1800BE520
	private Component Internal_AddComponentWithType(Type componentType) { }

	[TypeInferenceRuleAttribute] // RVA: 0xB9DD0 Offset: 0xB91D0 VA: 0x1800B9DD0
	public Component AddComponent(Type componentType) { }

	public T AddComponent<T>() { }
	/* GenericInstMethod :
	|
	|-GameObject.AddComponent<AICoverPoint>
	|-GameObject.AddComponent<AddToHeightMap>
	|-GameObject.AddComponent<AddToWaterMap>
	|-GameObject.AddComponent<AudioInterceptComponent>
	|-GameObject.AddComponent<BaseEntityChild>
	|-GameObject.AddComponent<ColliderInfo>
	|-GameObject.AddComponent<CommunityEntity.Countdown>
	|-GameObject.AddComponent<CommunityEntity.FadeOut>
	|-GameObject.AddComponent<ConversationManager.Conversation>
	|-GameObject.AddComponent<DemoShotPlayback>
	|-GameObject.AddComponent<DemoShotRecorder>
	|-GameObject.AddComponent<DeployGuide>
	|-GameObject.AddComponent<DetachMonumentChildren>
	|-GameObject.AddComponent<ERSurfaceScript>
	|-GameObject.AddComponent<ERCrossingPrefabs>
	|-GameObject.AddComponent<ERCrossings>
	|-GameObject.AddComponent<ERIConnector>
	|-GameObject.AddComponent<ERPrefabInstance>
	|-GameObject.AddComponent<ERSideObjectInstance>
	|-GameObject.AddComponent<ERSideObjectSection>
	|-GameObject.AddComponent<ERSideWalkInstanceScript>
	|-GameObject.AddComponent<ERTerrain>
	|-GameObject.AddComponent<OQQCCQCDQQ>
	|-GameObject.AddComponent<EntityDebug>
	|-GameObject.AddComponent<EnvironmentVolume>
	|-GameObject.AddComponent<ExplosionDemoReactivator>
	|-GameObject.AddComponent<ApplicationControllerMonobehaviour>
	|-GameObject.AddComponent<BurstClothManager>
	|-GameObject.AddComponent<Skeleton>
	|-GameObject.AddComponent<TickComponent>
	|-GameObject.AddComponent<Gib>
	|-GameObject.AddComponent<HudMenuInput>
	|-GameObject.AddComponent<InvokeHandler>
	|-GameObject.AddComponent<InvokeHandlerFixedTime>
	|-GameObject.AddComponent<LightLOD>
	|-GameObject.AddComponent<LoadBalancer>
	|-GameObject.AddComponent<MeshLOD>
	|-GameObject.AddComponent<MeshPaintable3D>
	|-GameObject.AddComponent<MeshPaintable>
	|-GameObject.AddComponent<MidiConvar>
	|-GameObject.AddComponent<NeedsCursor>
	|-GameObject.AddComponent<NeedsKeyboard>
	|-GameObject.AddComponent<NeedsKeyboardInputField>
	|-GameObject.AddComponent<ObjectMotionVectorFix>
	|-GameObject.AddComponent<PlayerLoot>
	|-GameObject.AddComponent<PowerLineWire>
	|-GameObject.AddComponent<PowerLineWireSpan>
	|-GameObject.AddComponent<QueryVis>
	|-GameObject.AddComponent<ReflectionProbeEx>
	|-GameObject.AddComponent<RendererInfo>
	|-GameObject.AddComponent<RiverInfo>
	|-GameObject.AddComponent<DepthOfFieldFocusPoint>
	|-GameObject.AddComponent<LightingOverride>
	|-GameObject.AddComponent<NullMonoBehaviour>
	|-GameObject.AddComponent<IconOutline>
	|-GameObject.AddComponent<PropRenderer>
	|-GameObject.AddComponent<WorkshopSkin>
	|-GameObject.AddComponent<TMP_InputField>
	|-GameObject.AddComponent<TMP_SelectionCaret>
	|-GameObject.AddComponent<TMP_SubMeshUI>
	|-GameObject.AddComponent<TextMeshProUGUI>
	|-GameObject.AddComponent<TerrainAlphaMap>
	|-GameObject.AddComponent<TerrainBiomeMap>
	|-GameObject.AddComponent<TerrainCollision>
	|-GameObject.AddComponent<TerrainColors>
	|-GameObject.AddComponent<TerrainHeightMap>
	|-GameObject.AddComponent<TerrainMeta>
	|-GameObject.AddComponent<TerrainPath>
	|-GameObject.AddComponent<TerrainPhysics>
	|-GameObject.AddComponent<TerrainPlacementMap>
	|-GameObject.AddComponent<TerrainQuality>
	|-GameObject.AddComponent<TerrainSplatMap>
	|-GameObject.AddComponent<TerrainTexturing>
	|-GameObject.AddComponent<TerrainTopologyMap>
	|-GameObject.AddComponent<TerrainWaterMap>
	|-GameObject.AddComponent<TrainTrackSpline>
	|-GameObject.AddComponent<UIEscapeCapture>
	|-GameObject.AddComponent<AudioReverbZone>
	|-GameObject.AddComponent<AudioSource>
	|-GameObject.AddComponent<BoxCollider>
	|-GameObject.AddComponent<Camera>
	|-GameObject.AddComponent<Canvas>
	|-GameObject.AddComponent<CanvasGroup>
	|-GameObject.AddComponent<CanvasRenderer>
	|-GameObject.AddComponent<BaseInput>
	|-GameObject.AddComponent<LODGroup>
	|-GameObject.AddComponent<Light>
	|-GameObject.AddComponent<MeshCollider>
	|-GameObject.AddComponent<MeshFilter>
	|-GameObject.AddComponent<MeshRenderer>
	|-GameObject.AddComponent<RectTransform>
	|-GameObject.AddComponent<ReflectionProbe>
	|-GameObject.AddComponent<Renderer>
	|-GameObject.AddComponent<PostProcessVolume>
	|-GameObject.AddComponent<Rigidbody>
	|-GameObject.AddComponent<SkinnedMeshRenderer>
	|-GameObject.AddComponent<SpringJoint>
	|-GameObject.AddComponent<StreamingController>
	|-GameObject.AddComponent<Button>
	|-GameObject.AddComponent<Dropdown.DropdownItem>
	|-GameObject.AddComponent<Image>
	|-GameObject.AddComponent<InputField>
	|-GameObject.AddComponent<LayoutElement>
	|-GameObject.AddComponent<Outline>
	|-GameObject.AddComponent<RawImage>
	|-GameObject.AddComponent<RectMask2D>
	|-GameObject.AddComponent<Scrollbar>
	|-GameObject.AddComponent<Text>
	|-GameObject.AddComponent<UpdateHandler>
	|-GameObject.AddComponent<ViewModelRenderer>
	|-GameObject.AddComponent<WaterBody>
	|-GameObject.AddComponent<object>
	*/

	[FreeFunctionAttribute] // RVA: 0xBE650 Offset: 0xBDA50 VA: 0x1800BE650
	public Transform get_transform() { }

	public int get_layer() { }

	public void set_layer(int value) { }

	[NativeMethodAttribute] // RVA: 0xBE7F0 Offset: 0xBDBF0 VA: 0x1800BE7F0
	public void SetActive(bool value) { }

	[NativeMethodAttribute] // RVA: 0xBE870 Offset: 0xBDC70 VA: 0x1800BE870
	public bool get_activeSelf() { }

	[NativeMethodAttribute] // RVA: 0xBEA60 Offset: 0xBDE60 VA: 0x1800BEA60
	public bool get_activeInHierarchy() { }

	[NativeMethodAttribute] // RVA: 0xBEBA0 Offset: 0xBDFA0 VA: 0x1800BEBA0
	public bool get_isStatic() { }

	[NativeMethodAttribute] // RVA: 0xBECF0 Offset: 0xBE0F0 VA: 0x1800BECF0
	public void set_isStatic(bool value) { }

	[FreeFunctionAttribute] // RVA: 0xBED70 Offset: 0xBE170 VA: 0x1800BED70
	public string get_tag() { }

	[FreeFunctionAttribute] // RVA: 0xBEE70 Offset: 0xBE270 VA: 0x1800BEE70
	public void set_tag(string value) { }

	[FreeFunctionAttribute] // RVA: 0xBEF20 Offset: 0xBE320 VA: 0x1800BEF20
	public bool CompareTag(string tag) { }

	[FreeFunctionAttribute] // RVA: 0xBF050 Offset: 0xBE450 VA: 0x1800BF050
	public void SendMessage(string methodName, object value, SendMessageOptions options) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public void SendMessage(string methodName, object value) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public void SendMessage(string methodName) { }

	[FreeFunctionAttribute] // RVA: 0xBF1E0 Offset: 0xBE5E0 VA: 0x1800BF1E0
	public void BroadcastMessage(string methodName, object parameter, SendMessageOptions options) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public void BroadcastMessage(string methodName, object parameter) { }

	public void .ctor(string name) { }

	public void .ctor() { }

	public void .ctor(string name, Type[] components) { }

	[FreeFunctionAttribute] // RVA: 0xC0820 Offset: 0xBFC20 VA: 0x1800C0820
	private static void Internal_CreateGameObject(GameObject self, string name) { }

	[FreeFunctionAttribute] // RVA: 0xC0930 Offset: 0xBFD30 VA: 0x1800C0930
	public static GameObject Find(string name) { }

	public GameObject get_gameObject() { }

}

