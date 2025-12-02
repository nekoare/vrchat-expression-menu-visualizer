using UnityEngine;

// Individual marker for generated menu items
#if VRC_SDK_VRCSDK3
namespace VRCExpressionMenuVisualizer
{
    public class ExprMenuVisualizerGenerated : MonoBehaviour, VRC.SDKBase.IEditorOnly { }
}
#else
namespace VRCExpressionMenuVisualizer
{
    public class ExprMenuVisualizerGenerated : MonoBehaviour { }
}
#endif
