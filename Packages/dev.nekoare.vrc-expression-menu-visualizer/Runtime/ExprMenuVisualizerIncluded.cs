using UnityEngine;

// Individual marker for included (non-excluded) menu items
#if VRC_SDK_VRCSDK3
namespace VRCExpressionMenuVisualizer
{
    public class ExprMenuVisualizerIncluded : MonoBehaviour, VRC.SDKBase.IEditorOnly { }
}
#else
namespace VRCExpressionMenuVisualizer
{
    public class ExprMenuVisualizerIncluded : MonoBehaviour { }
}
#endif
