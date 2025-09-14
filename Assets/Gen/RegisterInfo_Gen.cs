using Puerts.TypeMapping;
using Puerts;

namespace PuertsStaticWrap
{
#if ENABLE_IL2CPP
    [UnityEngine.Scripting.Preserve]
#endif
    public static class PuerRegisterInfo_Gen
    {
        
        public static RegisterInfo GetRegisterInfo_UnityEngine_Debug_Wrap() 
        {
            return new RegisterInfo 
            {
#if !EXPERIMENTAL_IL2CPP_PUERTS
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {".ctor", new MemberRegisterInfo { Name = ".ctor", IsStatic = false, MemberType = MemberType.Constructor, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Constructor = UnityEngine_Debug_Wrap.Constructor
#endif
                    }},
                    {"DrawLine_static", new MemberRegisterInfo { Name = "DrawLine", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Debug_Wrap.F_DrawLine
#endif
                    }},
                    {"DrawRay_static", new MemberRegisterInfo { Name = "DrawRay", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Debug_Wrap.F_DrawRay
#endif
                    }},
                    {"Break_static", new MemberRegisterInfo { Name = "Break", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Debug_Wrap.F_Break
#endif
                    }},
                    {"DebugBreak_static", new MemberRegisterInfo { Name = "DebugBreak", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Debug_Wrap.F_DebugBreak
#endif
                    }},
                    {"Log_static", new MemberRegisterInfo { Name = "Log", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Debug_Wrap.F_Log
#endif
                    }},
                    {"LogFormat_static", new MemberRegisterInfo { Name = "LogFormat", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Debug_Wrap.F_LogFormat
#endif
                    }},
                    {"LogError_static", new MemberRegisterInfo { Name = "LogError", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Debug_Wrap.F_LogError
#endif
                    }},
                    {"LogErrorFormat_static", new MemberRegisterInfo { Name = "LogErrorFormat", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Debug_Wrap.F_LogErrorFormat
#endif
                    }},
                    {"ClearDeveloperConsole_static", new MemberRegisterInfo { Name = "ClearDeveloperConsole", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Debug_Wrap.F_ClearDeveloperConsole
#endif
                    }},
                    {"LogException_static", new MemberRegisterInfo { Name = "LogException", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Debug_Wrap.F_LogException
#endif
                    }},
                    {"LogWarning_static", new MemberRegisterInfo { Name = "LogWarning", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Debug_Wrap.F_LogWarning
#endif
                    }},
                    {"LogWarningFormat_static", new MemberRegisterInfo { Name = "LogWarningFormat", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Debug_Wrap.F_LogWarningFormat
#endif
                    }},
                    {"Assert_static", new MemberRegisterInfo { Name = "Assert", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Debug_Wrap.F_Assert
#endif
                    }},
                    {"AssertFormat_static", new MemberRegisterInfo { Name = "AssertFormat", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Debug_Wrap.F_AssertFormat
#endif
                    }},
                    {"LogAssertion_static", new MemberRegisterInfo { Name = "LogAssertion", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Debug_Wrap.F_LogAssertion
#endif
                    }},
                    {"LogAssertionFormat_static", new MemberRegisterInfo { Name = "LogAssertionFormat", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Debug_Wrap.F_LogAssertionFormat
#endif
                    }},
                    {"unityLogger_static", new MemberRegisterInfo { Name = "unityLogger", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_Debug_Wrap.G_unityLogger
#endif
                    }},
                    {"developerConsoleVisible_static", new MemberRegisterInfo { Name = "developerConsoleVisible", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_Debug_Wrap.G_developerConsoleVisible, PropertySetter = UnityEngine_Debug_Wrap.S_developerConsoleVisible
#endif
                    }},
                    {"isDebugBuild_static", new MemberRegisterInfo { Name = "isDebugBuild", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_Debug_Wrap.G_isDebugBuild
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_UnityEngine_Vector3_Wrap() 
        {
            return new RegisterInfo 
            {
#if !EXPERIMENTAL_IL2CPP_PUERTS
                BlittableCopy = true,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {".ctor", new MemberRegisterInfo { Name = ".ctor", IsStatic = false, MemberType = MemberType.Constructor, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Constructor = UnityEngine_Vector3_Wrap.Constructor
#endif
                    }},
                    {"Set", new MemberRegisterInfo { Name = "Set", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Vector3_Wrap.M_Set
#endif
                    }},
                    {"Scale", new MemberRegisterInfo { Name = "Scale", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Vector3_Wrap.M_Scale
#endif
                    }},
                    {"GetHashCode", new MemberRegisterInfo { Name = "GetHashCode", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Vector3_Wrap.M_GetHashCode
#endif
                    }},
                    {"Equals", new MemberRegisterInfo { Name = "Equals", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Vector3_Wrap.M_Equals
#endif
                    }},
                    {"Normalize", new MemberRegisterInfo { Name = "Normalize", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Vector3_Wrap.M_Normalize
#endif
                    }},
                    {"op_Addition_static", new MemberRegisterInfo { Name = "op_Addition", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Vector3_Wrap.O_op_Addition
#endif
                    }},
                    {"op_Subtraction_static", new MemberRegisterInfo { Name = "op_Subtraction", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Vector3_Wrap.O_op_Subtraction
#endif
                    }},
                    {"op_UnaryNegation_static", new MemberRegisterInfo { Name = "op_UnaryNegation", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Vector3_Wrap.O_op_UnaryNegation
#endif
                    }},
                    {"op_Multiply_static", new MemberRegisterInfo { Name = "op_Multiply", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Vector3_Wrap.O_op_Multiply
#endif
                    }},
                    {"op_Division_static", new MemberRegisterInfo { Name = "op_Division", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Vector3_Wrap.O_op_Division
#endif
                    }},
                    {"op_Equality_static", new MemberRegisterInfo { Name = "op_Equality", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Vector3_Wrap.O_op_Equality
#endif
                    }},
                    {"op_Inequality_static", new MemberRegisterInfo { Name = "op_Inequality", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Vector3_Wrap.O_op_Inequality
#endif
                    }},
                    {"ToString", new MemberRegisterInfo { Name = "ToString", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Vector3_Wrap.M_ToString
#endif
                    }},
                    {"get_Item", new MemberRegisterInfo { Name = "get_Item", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Vector3_Wrap.GetItem
#endif
                    }},
                    {"set_Item", new MemberRegisterInfo { Name = "set_Item", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Vector3_Wrap.SetItem
#endif
                    }},
                    {"normalized", new MemberRegisterInfo { Name = "normalized", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_Vector3_Wrap.G_normalized
#endif
                    }},
                    {"magnitude", new MemberRegisterInfo { Name = "magnitude", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_Vector3_Wrap.G_magnitude
#endif
                    }},
                    {"sqrMagnitude", new MemberRegisterInfo { Name = "sqrMagnitude", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_Vector3_Wrap.G_sqrMagnitude
#endif
                    }},
                    {"x", new MemberRegisterInfo { Name = "x", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_Vector3_Wrap.G_x, PropertySetter = UnityEngine_Vector3_Wrap.S_x
#endif
                    }},
                    {"y", new MemberRegisterInfo { Name = "y", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_Vector3_Wrap.G_y, PropertySetter = UnityEngine_Vector3_Wrap.S_y
#endif
                    }},
                    {"z", new MemberRegisterInfo { Name = "z", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_Vector3_Wrap.G_z, PropertySetter = UnityEngine_Vector3_Wrap.S_z
#endif
                    }},
                    {"Slerp_static", new MemberRegisterInfo { Name = "Slerp", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Vector3_Wrap.F_Slerp
#endif
                    }},
                    {"SlerpUnclamped_static", new MemberRegisterInfo { Name = "SlerpUnclamped", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Vector3_Wrap.F_SlerpUnclamped
#endif
                    }},
                    {"OrthoNormalize_static", new MemberRegisterInfo { Name = "OrthoNormalize", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Vector3_Wrap.F_OrthoNormalize
#endif
                    }},
                    {"RotateTowards_static", new MemberRegisterInfo { Name = "RotateTowards", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Vector3_Wrap.F_RotateTowards
#endif
                    }},
                    {"Lerp_static", new MemberRegisterInfo { Name = "Lerp", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Vector3_Wrap.F_Lerp
#endif
                    }},
                    {"LerpUnclamped_static", new MemberRegisterInfo { Name = "LerpUnclamped", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Vector3_Wrap.F_LerpUnclamped
#endif
                    }},
                    {"MoveTowards_static", new MemberRegisterInfo { Name = "MoveTowards", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Vector3_Wrap.F_MoveTowards
#endif
                    }},
                    {"SmoothDamp_static", new MemberRegisterInfo { Name = "SmoothDamp", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Vector3_Wrap.F_SmoothDamp
#endif
                    }},
                    {"Scale_static", new MemberRegisterInfo { Name = "Scale", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Vector3_Wrap.F_Scale
#endif
                    }},
                    {"Cross_static", new MemberRegisterInfo { Name = "Cross", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Vector3_Wrap.F_Cross
#endif
                    }},
                    {"Reflect_static", new MemberRegisterInfo { Name = "Reflect", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Vector3_Wrap.F_Reflect
#endif
                    }},
                    {"Normalize_static", new MemberRegisterInfo { Name = "Normalize", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Vector3_Wrap.F_Normalize
#endif
                    }},
                    {"Dot_static", new MemberRegisterInfo { Name = "Dot", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Vector3_Wrap.F_Dot
#endif
                    }},
                    {"Project_static", new MemberRegisterInfo { Name = "Project", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Vector3_Wrap.F_Project
#endif
                    }},
                    {"ProjectOnPlane_static", new MemberRegisterInfo { Name = "ProjectOnPlane", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Vector3_Wrap.F_ProjectOnPlane
#endif
                    }},
                    {"Angle_static", new MemberRegisterInfo { Name = "Angle", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Vector3_Wrap.F_Angle
#endif
                    }},
                    {"SignedAngle_static", new MemberRegisterInfo { Name = "SignedAngle", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Vector3_Wrap.F_SignedAngle
#endif
                    }},
                    {"Distance_static", new MemberRegisterInfo { Name = "Distance", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Vector3_Wrap.F_Distance
#endif
                    }},
                    {"ClampMagnitude_static", new MemberRegisterInfo { Name = "ClampMagnitude", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Vector3_Wrap.F_ClampMagnitude
#endif
                    }},
                    {"Magnitude_static", new MemberRegisterInfo { Name = "Magnitude", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Vector3_Wrap.F_Magnitude
#endif
                    }},
                    {"SqrMagnitude_static", new MemberRegisterInfo { Name = "SqrMagnitude", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Vector3_Wrap.F_SqrMagnitude
#endif
                    }},
                    {"Min_static", new MemberRegisterInfo { Name = "Min", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Vector3_Wrap.F_Min
#endif
                    }},
                    {"Max_static", new MemberRegisterInfo { Name = "Max", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Vector3_Wrap.F_Max
#endif
                    }},
                    {"zero_static", new MemberRegisterInfo { Name = "zero", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_Vector3_Wrap.G_zero
#endif
                    }},
                    {"one_static", new MemberRegisterInfo { Name = "one", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_Vector3_Wrap.G_one
#endif
                    }},
                    {"forward_static", new MemberRegisterInfo { Name = "forward", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_Vector3_Wrap.G_forward
#endif
                    }},
                    {"back_static", new MemberRegisterInfo { Name = "back", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_Vector3_Wrap.G_back
#endif
                    }},
                    {"up_static", new MemberRegisterInfo { Name = "up", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_Vector3_Wrap.G_up
#endif
                    }},
                    {"down_static", new MemberRegisterInfo { Name = "down", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_Vector3_Wrap.G_down
#endif
                    }},
                    {"left_static", new MemberRegisterInfo { Name = "left", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_Vector3_Wrap.G_left
#endif
                    }},
                    {"right_static", new MemberRegisterInfo { Name = "right", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_Vector3_Wrap.G_right
#endif
                    }},
                    {"positiveInfinity_static", new MemberRegisterInfo { Name = "positiveInfinity", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_Vector3_Wrap.G_positiveInfinity
#endif
                    }},
                    {"negativeInfinity_static", new MemberRegisterInfo { Name = "negativeInfinity", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_Vector3_Wrap.G_negativeInfinity
#endif
                    }},
                    {"kEpsilon_static", new MemberRegisterInfo { Name = "kEpsilon", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_Vector3_Wrap.G_kEpsilon
#endif
                    }},
                    {"kEpsilonNormalSqrt_static", new MemberRegisterInfo { Name = "kEpsilonNormalSqrt", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_Vector3_Wrap.G_kEpsilonNormalSqrt
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_UnityEngine_Transform_Wrap() 
        {
            return new RegisterInfo 
            {
#if !EXPERIMENTAL_IL2CPP_PUERTS
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {"SetParent", new MemberRegisterInfo { Name = "SetParent", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Transform_Wrap.M_SetParent
#endif
                    }},
                    {"SetPositionAndRotation", new MemberRegisterInfo { Name = "SetPositionAndRotation", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Transform_Wrap.M_SetPositionAndRotation
#endif
                    }},
                    {"SetLocalPositionAndRotation", new MemberRegisterInfo { Name = "SetLocalPositionAndRotation", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Transform_Wrap.M_SetLocalPositionAndRotation
#endif
                    }},
                    {"GetPositionAndRotation", new MemberRegisterInfo { Name = "GetPositionAndRotation", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Transform_Wrap.M_GetPositionAndRotation
#endif
                    }},
                    {"GetLocalPositionAndRotation", new MemberRegisterInfo { Name = "GetLocalPositionAndRotation", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Transform_Wrap.M_GetLocalPositionAndRotation
#endif
                    }},
                    {"Translate", new MemberRegisterInfo { Name = "Translate", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Transform_Wrap.M_Translate
#endif
                    }},
                    {"Rotate", new MemberRegisterInfo { Name = "Rotate", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Transform_Wrap.M_Rotate
#endif
                    }},
                    {"RotateAround", new MemberRegisterInfo { Name = "RotateAround", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Transform_Wrap.M_RotateAround
#endif
                    }},
                    {"LookAt", new MemberRegisterInfo { Name = "LookAt", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Transform_Wrap.M_LookAt
#endif
                    }},
                    {"TransformDirection", new MemberRegisterInfo { Name = "TransformDirection", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Transform_Wrap.M_TransformDirection
#endif
                    }},
                    {"InverseTransformDirection", new MemberRegisterInfo { Name = "InverseTransformDirection", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Transform_Wrap.M_InverseTransformDirection
#endif
                    }},
                    {"TransformVector", new MemberRegisterInfo { Name = "TransformVector", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Transform_Wrap.M_TransformVector
#endif
                    }},
                    {"InverseTransformVector", new MemberRegisterInfo { Name = "InverseTransformVector", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Transform_Wrap.M_InverseTransformVector
#endif
                    }},
                    {"TransformPoint", new MemberRegisterInfo { Name = "TransformPoint", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Transform_Wrap.M_TransformPoint
#endif
                    }},
                    {"InverseTransformPoint", new MemberRegisterInfo { Name = "InverseTransformPoint", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Transform_Wrap.M_InverseTransformPoint
#endif
                    }},
                    {"DetachChildren", new MemberRegisterInfo { Name = "DetachChildren", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Transform_Wrap.M_DetachChildren
#endif
                    }},
                    {"SetAsFirstSibling", new MemberRegisterInfo { Name = "SetAsFirstSibling", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Transform_Wrap.M_SetAsFirstSibling
#endif
                    }},
                    {"SetAsLastSibling", new MemberRegisterInfo { Name = "SetAsLastSibling", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Transform_Wrap.M_SetAsLastSibling
#endif
                    }},
                    {"SetSiblingIndex", new MemberRegisterInfo { Name = "SetSiblingIndex", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Transform_Wrap.M_SetSiblingIndex
#endif
                    }},
                    {"GetSiblingIndex", new MemberRegisterInfo { Name = "GetSiblingIndex", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Transform_Wrap.M_GetSiblingIndex
#endif
                    }},
                    {"Find", new MemberRegisterInfo { Name = "Find", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Transform_Wrap.M_Find
#endif
                    }},
                    {"IsChildOf", new MemberRegisterInfo { Name = "IsChildOf", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Transform_Wrap.M_IsChildOf
#endif
                    }},
                    {"GetEnumerator", new MemberRegisterInfo { Name = "GetEnumerator", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Transform_Wrap.M_GetEnumerator
#endif
                    }},
                    {"GetChild", new MemberRegisterInfo { Name = "GetChild", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Transform_Wrap.M_GetChild
#endif
                    }},
                    {"position", new MemberRegisterInfo { Name = "position", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_Transform_Wrap.G_position, PropertySetter = UnityEngine_Transform_Wrap.S_position
#endif
                    }},
                    {"localPosition", new MemberRegisterInfo { Name = "localPosition", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_Transform_Wrap.G_localPosition, PropertySetter = UnityEngine_Transform_Wrap.S_localPosition
#endif
                    }},
                    {"eulerAngles", new MemberRegisterInfo { Name = "eulerAngles", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_Transform_Wrap.G_eulerAngles, PropertySetter = UnityEngine_Transform_Wrap.S_eulerAngles
#endif
                    }},
                    {"localEulerAngles", new MemberRegisterInfo { Name = "localEulerAngles", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_Transform_Wrap.G_localEulerAngles, PropertySetter = UnityEngine_Transform_Wrap.S_localEulerAngles
#endif
                    }},
                    {"right", new MemberRegisterInfo { Name = "right", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_Transform_Wrap.G_right, PropertySetter = UnityEngine_Transform_Wrap.S_right
#endif
                    }},
                    {"up", new MemberRegisterInfo { Name = "up", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_Transform_Wrap.G_up, PropertySetter = UnityEngine_Transform_Wrap.S_up
#endif
                    }},
                    {"forward", new MemberRegisterInfo { Name = "forward", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_Transform_Wrap.G_forward, PropertySetter = UnityEngine_Transform_Wrap.S_forward
#endif
                    }},
                    {"rotation", new MemberRegisterInfo { Name = "rotation", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_Transform_Wrap.G_rotation, PropertySetter = UnityEngine_Transform_Wrap.S_rotation
#endif
                    }},
                    {"localRotation", new MemberRegisterInfo { Name = "localRotation", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_Transform_Wrap.G_localRotation, PropertySetter = UnityEngine_Transform_Wrap.S_localRotation
#endif
                    }},
                    {"localScale", new MemberRegisterInfo { Name = "localScale", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_Transform_Wrap.G_localScale, PropertySetter = UnityEngine_Transform_Wrap.S_localScale
#endif
                    }},
                    {"parent", new MemberRegisterInfo { Name = "parent", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_Transform_Wrap.G_parent, PropertySetter = UnityEngine_Transform_Wrap.S_parent
#endif
                    }},
                    {"worldToLocalMatrix", new MemberRegisterInfo { Name = "worldToLocalMatrix", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_Transform_Wrap.G_worldToLocalMatrix
#endif
                    }},
                    {"localToWorldMatrix", new MemberRegisterInfo { Name = "localToWorldMatrix", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_Transform_Wrap.G_localToWorldMatrix
#endif
                    }},
                    {"root", new MemberRegisterInfo { Name = "root", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_Transform_Wrap.G_root
#endif
                    }},
                    {"childCount", new MemberRegisterInfo { Name = "childCount", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_Transform_Wrap.G_childCount
#endif
                    }},
                    {"lossyScale", new MemberRegisterInfo { Name = "lossyScale", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_Transform_Wrap.G_lossyScale
#endif
                    }},
                    {"hasChanged", new MemberRegisterInfo { Name = "hasChanged", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_Transform_Wrap.G_hasChanged, PropertySetter = UnityEngine_Transform_Wrap.S_hasChanged
#endif
                    }},
                    {"hierarchyCapacity", new MemberRegisterInfo { Name = "hierarchyCapacity", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_Transform_Wrap.G_hierarchyCapacity, PropertySetter = UnityEngine_Transform_Wrap.S_hierarchyCapacity
#endif
                    }},
                    {"hierarchyCount", new MemberRegisterInfo { Name = "hierarchyCount", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_Transform_Wrap.G_hierarchyCount
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_UnityEngine_Component_Wrap() 
        {
            return new RegisterInfo 
            {
#if !EXPERIMENTAL_IL2CPP_PUERTS
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {".ctor", new MemberRegisterInfo { Name = ".ctor", IsStatic = false, MemberType = MemberType.Constructor, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Constructor = UnityEngine_Component_Wrap.Constructor
#endif
                    }},
                    {"GetComponent", new MemberRegisterInfo { Name = "GetComponent", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Component_Wrap.M_GetComponent
#endif
                    }},
                    {"TryGetComponent", new MemberRegisterInfo { Name = "TryGetComponent", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Component_Wrap.M_TryGetComponent
#endif
                    }},
                    {"GetComponentInChildren", new MemberRegisterInfo { Name = "GetComponentInChildren", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Component_Wrap.M_GetComponentInChildren
#endif
                    }},
                    {"GetComponentsInChildren", new MemberRegisterInfo { Name = "GetComponentsInChildren", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Component_Wrap.M_GetComponentsInChildren
#endif
                    }},
                    {"GetComponentInParent", new MemberRegisterInfo { Name = "GetComponentInParent", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Component_Wrap.M_GetComponentInParent
#endif
                    }},
                    {"GetComponentsInParent", new MemberRegisterInfo { Name = "GetComponentsInParent", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Component_Wrap.M_GetComponentsInParent
#endif
                    }},
                    {"GetComponents", new MemberRegisterInfo { Name = "GetComponents", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Component_Wrap.M_GetComponents
#endif
                    }},
                    {"CompareTag", new MemberRegisterInfo { Name = "CompareTag", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Component_Wrap.M_CompareTag
#endif
                    }},
                    {"SendMessageUpwards", new MemberRegisterInfo { Name = "SendMessageUpwards", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Component_Wrap.M_SendMessageUpwards
#endif
                    }},
                    {"SendMessage", new MemberRegisterInfo { Name = "SendMessage", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Component_Wrap.M_SendMessage
#endif
                    }},
                    {"BroadcastMessage", new MemberRegisterInfo { Name = "BroadcastMessage", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Component_Wrap.M_BroadcastMessage
#endif
                    }},
                    {"transform", new MemberRegisterInfo { Name = "transform", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_Component_Wrap.G_transform
#endif
                    }},
                    {"gameObject", new MemberRegisterInfo { Name = "gameObject", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_Component_Wrap.G_gameObject
#endif
                    }},
                    {"tag", new MemberRegisterInfo { Name = "tag", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_Component_Wrap.G_tag, PropertySetter = UnityEngine_Component_Wrap.S_tag
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_UnityEngine_GameObject_Wrap() 
        {
            return new RegisterInfo 
            {
#if !EXPERIMENTAL_IL2CPP_PUERTS
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {".ctor", new MemberRegisterInfo { Name = ".ctor", IsStatic = false, MemberType = MemberType.Constructor, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Constructor = UnityEngine_GameObject_Wrap.Constructor
#endif
                    }},
                    {"GetComponent", new MemberRegisterInfo { Name = "GetComponent", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_GameObject_Wrap.M_GetComponent
#endif
                    }},
                    {"GetComponentInChildren", new MemberRegisterInfo { Name = "GetComponentInChildren", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_GameObject_Wrap.M_GetComponentInChildren
#endif
                    }},
                    {"GetComponentInParent", new MemberRegisterInfo { Name = "GetComponentInParent", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_GameObject_Wrap.M_GetComponentInParent
#endif
                    }},
                    {"GetComponents", new MemberRegisterInfo { Name = "GetComponents", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_GameObject_Wrap.M_GetComponents
#endif
                    }},
                    {"GetComponentsInChildren", new MemberRegisterInfo { Name = "GetComponentsInChildren", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_GameObject_Wrap.M_GetComponentsInChildren
#endif
                    }},
                    {"GetComponentsInParent", new MemberRegisterInfo { Name = "GetComponentsInParent", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_GameObject_Wrap.M_GetComponentsInParent
#endif
                    }},
                    {"TryGetComponent", new MemberRegisterInfo { Name = "TryGetComponent", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_GameObject_Wrap.M_TryGetComponent
#endif
                    }},
                    {"SendMessageUpwards", new MemberRegisterInfo { Name = "SendMessageUpwards", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_GameObject_Wrap.M_SendMessageUpwards
#endif
                    }},
                    {"SendMessage", new MemberRegisterInfo { Name = "SendMessage", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_GameObject_Wrap.M_SendMessage
#endif
                    }},
                    {"BroadcastMessage", new MemberRegisterInfo { Name = "BroadcastMessage", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_GameObject_Wrap.M_BroadcastMessage
#endif
                    }},
                    {"AddComponent", new MemberRegisterInfo { Name = "AddComponent", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_GameObject_Wrap.M_AddComponent
#endif
                    }},
                    {"SetActive", new MemberRegisterInfo { Name = "SetActive", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_GameObject_Wrap.M_SetActive
#endif
                    }},
                    {"CompareTag", new MemberRegisterInfo { Name = "CompareTag", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_GameObject_Wrap.M_CompareTag
#endif
                    }},
                    {"transform", new MemberRegisterInfo { Name = "transform", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_GameObject_Wrap.G_transform
#endif
                    }},
                    {"layer", new MemberRegisterInfo { Name = "layer", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_GameObject_Wrap.G_layer, PropertySetter = UnityEngine_GameObject_Wrap.S_layer
#endif
                    }},
                    {"activeSelf", new MemberRegisterInfo { Name = "activeSelf", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_GameObject_Wrap.G_activeSelf
#endif
                    }},
                    {"activeInHierarchy", new MemberRegisterInfo { Name = "activeInHierarchy", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_GameObject_Wrap.G_activeInHierarchy
#endif
                    }},
                    {"isStatic", new MemberRegisterInfo { Name = "isStatic", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_GameObject_Wrap.G_isStatic, PropertySetter = UnityEngine_GameObject_Wrap.S_isStatic
#endif
                    }},
                    {"tag", new MemberRegisterInfo { Name = "tag", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_GameObject_Wrap.G_tag, PropertySetter = UnityEngine_GameObject_Wrap.S_tag
#endif
                    }},
                    {"scene", new MemberRegisterInfo { Name = "scene", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_GameObject_Wrap.G_scene
#endif
                    }},
                    {"sceneCullingMask", new MemberRegisterInfo { Name = "sceneCullingMask", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_GameObject_Wrap.G_sceneCullingMask
#endif
                    }},
                    {"gameObject", new MemberRegisterInfo { Name = "gameObject", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_GameObject_Wrap.G_gameObject
#endif
                    }},
                    {"CreatePrimitive_static", new MemberRegisterInfo { Name = "CreatePrimitive", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_GameObject_Wrap.F_CreatePrimitive
#endif
                    }},
                    {"FindWithTag_static", new MemberRegisterInfo { Name = "FindWithTag", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_GameObject_Wrap.F_FindWithTag
#endif
                    }},
                    {"FindGameObjectWithTag_static", new MemberRegisterInfo { Name = "FindGameObjectWithTag", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_GameObject_Wrap.F_FindGameObjectWithTag
#endif
                    }},
                    {"FindGameObjectsWithTag_static", new MemberRegisterInfo { Name = "FindGameObjectsWithTag", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_GameObject_Wrap.F_FindGameObjectsWithTag
#endif
                    }},
                    {"Find_static", new MemberRegisterInfo { Name = "Find", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_GameObject_Wrap.F_Find
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_UnityEngine_Object_Wrap() 
        {
            return new RegisterInfo 
            {
#if !EXPERIMENTAL_IL2CPP_PUERTS
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {".ctor", new MemberRegisterInfo { Name = ".ctor", IsStatic = false, MemberType = MemberType.Constructor, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Constructor = UnityEngine_Object_Wrap.Constructor
#endif
                    }},
                    {"GetInstanceID", new MemberRegisterInfo { Name = "GetInstanceID", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Object_Wrap.M_GetInstanceID
#endif
                    }},
                    {"GetHashCode", new MemberRegisterInfo { Name = "GetHashCode", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Object_Wrap.M_GetHashCode
#endif
                    }},
                    {"Equals", new MemberRegisterInfo { Name = "Equals", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Object_Wrap.M_Equals
#endif
                    }},
                    {"ToString", new MemberRegisterInfo { Name = "ToString", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Object_Wrap.M_ToString
#endif
                    }},
                    {"op_Equality_static", new MemberRegisterInfo { Name = "op_Equality", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Object_Wrap.O_op_Equality
#endif
                    }},
                    {"op_Inequality_static", new MemberRegisterInfo { Name = "op_Inequality", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Object_Wrap.O_op_Inequality
#endif
                    }},
                    {"name", new MemberRegisterInfo { Name = "name", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_Object_Wrap.G_name, PropertySetter = UnityEngine_Object_Wrap.S_name
#endif
                    }},
                    {"hideFlags", new MemberRegisterInfo { Name = "hideFlags", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_Object_Wrap.G_hideFlags, PropertySetter = UnityEngine_Object_Wrap.S_hideFlags
#endif
                    }},
                    {"Instantiate_static", new MemberRegisterInfo { Name = "Instantiate", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Object_Wrap.F_Instantiate
#endif
                    }},
                    {"Destroy_static", new MemberRegisterInfo { Name = "Destroy", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Object_Wrap.F_Destroy
#endif
                    }},
                    {"DestroyImmediate_static", new MemberRegisterInfo { Name = "DestroyImmediate", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Object_Wrap.F_DestroyImmediate
#endif
                    }},
                    {"FindObjectsOfType_static", new MemberRegisterInfo { Name = "FindObjectsOfType", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Object_Wrap.F_FindObjectsOfType
#endif
                    }},
                    {"FindObjectsByType_static", new MemberRegisterInfo { Name = "FindObjectsByType", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Object_Wrap.F_FindObjectsByType
#endif
                    }},
                    {"DontDestroyOnLoad_static", new MemberRegisterInfo { Name = "DontDestroyOnLoad", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Object_Wrap.F_DontDestroyOnLoad
#endif
                    }},
                    {"FindObjectOfType_static", new MemberRegisterInfo { Name = "FindObjectOfType", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Object_Wrap.F_FindObjectOfType
#endif
                    }},
                    {"FindFirstObjectByType_static", new MemberRegisterInfo { Name = "FindFirstObjectByType", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Object_Wrap.F_FindFirstObjectByType
#endif
                    }},
                    {"FindAnyObjectByType_static", new MemberRegisterInfo { Name = "FindAnyObjectByType", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Object_Wrap.F_FindAnyObjectByType
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_UnityEngine_ParticleSystem_Wrap() 
        {
            return new RegisterInfo 
            {
#if !EXPERIMENTAL_IL2CPP_PUERTS
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {".ctor", new MemberRegisterInfo { Name = ".ctor", IsStatic = false, MemberType = MemberType.Constructor, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Constructor = UnityEngine_ParticleSystem_Wrap.Constructor
#endif
                    }},
                    {"SetParticles", new MemberRegisterInfo { Name = "SetParticles", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_ParticleSystem_Wrap.M_SetParticles
#endif
                    }},
                    {"GetParticles", new MemberRegisterInfo { Name = "GetParticles", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_ParticleSystem_Wrap.M_GetParticles
#endif
                    }},
                    {"SetCustomParticleData", new MemberRegisterInfo { Name = "SetCustomParticleData", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_ParticleSystem_Wrap.M_SetCustomParticleData
#endif
                    }},
                    {"GetCustomParticleData", new MemberRegisterInfo { Name = "GetCustomParticleData", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_ParticleSystem_Wrap.M_GetCustomParticleData
#endif
                    }},
                    {"GetPlaybackState", new MemberRegisterInfo { Name = "GetPlaybackState", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_ParticleSystem_Wrap.M_GetPlaybackState
#endif
                    }},
                    {"SetPlaybackState", new MemberRegisterInfo { Name = "SetPlaybackState", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_ParticleSystem_Wrap.M_SetPlaybackState
#endif
                    }},
                    {"GetTrails", new MemberRegisterInfo { Name = "GetTrails", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_ParticleSystem_Wrap.M_GetTrails
#endif
                    }},
                    {"SetTrails", new MemberRegisterInfo { Name = "SetTrails", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_ParticleSystem_Wrap.M_SetTrails
#endif
                    }},
                    {"Simulate", new MemberRegisterInfo { Name = "Simulate", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_ParticleSystem_Wrap.M_Simulate
#endif
                    }},
                    {"Play", new MemberRegisterInfo { Name = "Play", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_ParticleSystem_Wrap.M_Play
#endif
                    }},
                    {"Pause", new MemberRegisterInfo { Name = "Pause", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_ParticleSystem_Wrap.M_Pause
#endif
                    }},
                    {"Stop", new MemberRegisterInfo { Name = "Stop", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_ParticleSystem_Wrap.M_Stop
#endif
                    }},
                    {"Clear", new MemberRegisterInfo { Name = "Clear", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_ParticleSystem_Wrap.M_Clear
#endif
                    }},
                    {"IsAlive", new MemberRegisterInfo { Name = "IsAlive", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_ParticleSystem_Wrap.M_IsAlive
#endif
                    }},
                    {"Emit", new MemberRegisterInfo { Name = "Emit", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_ParticleSystem_Wrap.M_Emit
#endif
                    }},
                    {"TriggerSubEmitter", new MemberRegisterInfo { Name = "TriggerSubEmitter", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_ParticleSystem_Wrap.M_TriggerSubEmitter
#endif
                    }},
                    {"AllocateAxisOfRotationAttribute", new MemberRegisterInfo { Name = "AllocateAxisOfRotationAttribute", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_ParticleSystem_Wrap.M_AllocateAxisOfRotationAttribute
#endif
                    }},
                    {"AllocateMeshIndexAttribute", new MemberRegisterInfo { Name = "AllocateMeshIndexAttribute", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_ParticleSystem_Wrap.M_AllocateMeshIndexAttribute
#endif
                    }},
                    {"AllocateCustomDataAttribute", new MemberRegisterInfo { Name = "AllocateCustomDataAttribute", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_ParticleSystem_Wrap.M_AllocateCustomDataAttribute
#endif
                    }},
                    {"isPlaying", new MemberRegisterInfo { Name = "isPlaying", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_ParticleSystem_Wrap.G_isPlaying
#endif
                    }},
                    {"isEmitting", new MemberRegisterInfo { Name = "isEmitting", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_ParticleSystem_Wrap.G_isEmitting
#endif
                    }},
                    {"isStopped", new MemberRegisterInfo { Name = "isStopped", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_ParticleSystem_Wrap.G_isStopped
#endif
                    }},
                    {"isPaused", new MemberRegisterInfo { Name = "isPaused", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_ParticleSystem_Wrap.G_isPaused
#endif
                    }},
                    {"particleCount", new MemberRegisterInfo { Name = "particleCount", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_ParticleSystem_Wrap.G_particleCount
#endif
                    }},
                    {"time", new MemberRegisterInfo { Name = "time", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_ParticleSystem_Wrap.G_time, PropertySetter = UnityEngine_ParticleSystem_Wrap.S_time
#endif
                    }},
                    {"randomSeed", new MemberRegisterInfo { Name = "randomSeed", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_ParticleSystem_Wrap.G_randomSeed, PropertySetter = UnityEngine_ParticleSystem_Wrap.S_randomSeed
#endif
                    }},
                    {"useAutoRandomSeed", new MemberRegisterInfo { Name = "useAutoRandomSeed", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_ParticleSystem_Wrap.G_useAutoRandomSeed, PropertySetter = UnityEngine_ParticleSystem_Wrap.S_useAutoRandomSeed
#endif
                    }},
                    {"proceduralSimulationSupported", new MemberRegisterInfo { Name = "proceduralSimulationSupported", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_ParticleSystem_Wrap.G_proceduralSimulationSupported
#endif
                    }},
                    {"main", new MemberRegisterInfo { Name = "main", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_ParticleSystem_Wrap.G_main
#endif
                    }},
                    {"emission", new MemberRegisterInfo { Name = "emission", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_ParticleSystem_Wrap.G_emission
#endif
                    }},
                    {"shape", new MemberRegisterInfo { Name = "shape", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_ParticleSystem_Wrap.G_shape
#endif
                    }},
                    {"velocityOverLifetime", new MemberRegisterInfo { Name = "velocityOverLifetime", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_ParticleSystem_Wrap.G_velocityOverLifetime
#endif
                    }},
                    {"limitVelocityOverLifetime", new MemberRegisterInfo { Name = "limitVelocityOverLifetime", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_ParticleSystem_Wrap.G_limitVelocityOverLifetime
#endif
                    }},
                    {"inheritVelocity", new MemberRegisterInfo { Name = "inheritVelocity", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_ParticleSystem_Wrap.G_inheritVelocity
#endif
                    }},
                    {"lifetimeByEmitterSpeed", new MemberRegisterInfo { Name = "lifetimeByEmitterSpeed", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_ParticleSystem_Wrap.G_lifetimeByEmitterSpeed
#endif
                    }},
                    {"forceOverLifetime", new MemberRegisterInfo { Name = "forceOverLifetime", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_ParticleSystem_Wrap.G_forceOverLifetime
#endif
                    }},
                    {"colorOverLifetime", new MemberRegisterInfo { Name = "colorOverLifetime", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_ParticleSystem_Wrap.G_colorOverLifetime
#endif
                    }},
                    {"colorBySpeed", new MemberRegisterInfo { Name = "colorBySpeed", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_ParticleSystem_Wrap.G_colorBySpeed
#endif
                    }},
                    {"sizeOverLifetime", new MemberRegisterInfo { Name = "sizeOverLifetime", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_ParticleSystem_Wrap.G_sizeOverLifetime
#endif
                    }},
                    {"sizeBySpeed", new MemberRegisterInfo { Name = "sizeBySpeed", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_ParticleSystem_Wrap.G_sizeBySpeed
#endif
                    }},
                    {"rotationOverLifetime", new MemberRegisterInfo { Name = "rotationOverLifetime", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_ParticleSystem_Wrap.G_rotationOverLifetime
#endif
                    }},
                    {"rotationBySpeed", new MemberRegisterInfo { Name = "rotationBySpeed", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_ParticleSystem_Wrap.G_rotationBySpeed
#endif
                    }},
                    {"externalForces", new MemberRegisterInfo { Name = "externalForces", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_ParticleSystem_Wrap.G_externalForces
#endif
                    }},
                    {"noise", new MemberRegisterInfo { Name = "noise", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_ParticleSystem_Wrap.G_noise
#endif
                    }},
                    {"collision", new MemberRegisterInfo { Name = "collision", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_ParticleSystem_Wrap.G_collision
#endif
                    }},
                    {"trigger", new MemberRegisterInfo { Name = "trigger", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_ParticleSystem_Wrap.G_trigger
#endif
                    }},
                    {"subEmitters", new MemberRegisterInfo { Name = "subEmitters", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_ParticleSystem_Wrap.G_subEmitters
#endif
                    }},
                    {"textureSheetAnimation", new MemberRegisterInfo { Name = "textureSheetAnimation", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_ParticleSystem_Wrap.G_textureSheetAnimation
#endif
                    }},
                    {"lights", new MemberRegisterInfo { Name = "lights", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_ParticleSystem_Wrap.G_lights
#endif
                    }},
                    {"trails", new MemberRegisterInfo { Name = "trails", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_ParticleSystem_Wrap.G_trails
#endif
                    }},
                    {"customData", new MemberRegisterInfo { Name = "customData", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_ParticleSystem_Wrap.G_customData
#endif
                    }},
                    {"ResetPreMappedBufferMemory_static", new MemberRegisterInfo { Name = "ResetPreMappedBufferMemory", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_ParticleSystem_Wrap.F_ResetPreMappedBufferMemory
#endif
                    }},
                    {"SetMaximumPreMappedBufferCounts_static", new MemberRegisterInfo { Name = "SetMaximumPreMappedBufferCounts", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_ParticleSystem_Wrap.F_SetMaximumPreMappedBufferCounts
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_UnityEngine_Canvas_Wrap() 
        {
            return new RegisterInfo 
            {
#if !EXPERIMENTAL_IL2CPP_PUERTS
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {".ctor", new MemberRegisterInfo { Name = ".ctor", IsStatic = false, MemberType = MemberType.Constructor, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Constructor = UnityEngine_Canvas_Wrap.Constructor
#endif
                    }},
                    {"add_preWillRenderCanvases_static", new MemberRegisterInfo { Name = "add_preWillRenderCanvases", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Canvas_Wrap.A_preWillRenderCanvases
#endif
                    }},
                    {"remove_preWillRenderCanvases_static", new MemberRegisterInfo { Name = "remove_preWillRenderCanvases", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Canvas_Wrap.R_preWillRenderCanvases
#endif
                    }},
                    {"add_willRenderCanvases_static", new MemberRegisterInfo { Name = "add_willRenderCanvases", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Canvas_Wrap.A_willRenderCanvases
#endif
                    }},
                    {"remove_willRenderCanvases_static", new MemberRegisterInfo { Name = "remove_willRenderCanvases", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Canvas_Wrap.R_willRenderCanvases
#endif
                    }},
                    {"renderMode", new MemberRegisterInfo { Name = "renderMode", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_Canvas_Wrap.G_renderMode, PropertySetter = UnityEngine_Canvas_Wrap.S_renderMode
#endif
                    }},
                    {"isRootCanvas", new MemberRegisterInfo { Name = "isRootCanvas", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_Canvas_Wrap.G_isRootCanvas
#endif
                    }},
                    {"pixelRect", new MemberRegisterInfo { Name = "pixelRect", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_Canvas_Wrap.G_pixelRect
#endif
                    }},
                    {"scaleFactor", new MemberRegisterInfo { Name = "scaleFactor", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_Canvas_Wrap.G_scaleFactor, PropertySetter = UnityEngine_Canvas_Wrap.S_scaleFactor
#endif
                    }},
                    {"referencePixelsPerUnit", new MemberRegisterInfo { Name = "referencePixelsPerUnit", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_Canvas_Wrap.G_referencePixelsPerUnit, PropertySetter = UnityEngine_Canvas_Wrap.S_referencePixelsPerUnit
#endif
                    }},
                    {"overridePixelPerfect", new MemberRegisterInfo { Name = "overridePixelPerfect", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_Canvas_Wrap.G_overridePixelPerfect, PropertySetter = UnityEngine_Canvas_Wrap.S_overridePixelPerfect
#endif
                    }},
                    {"pixelPerfect", new MemberRegisterInfo { Name = "pixelPerfect", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_Canvas_Wrap.G_pixelPerfect, PropertySetter = UnityEngine_Canvas_Wrap.S_pixelPerfect
#endif
                    }},
                    {"planeDistance", new MemberRegisterInfo { Name = "planeDistance", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_Canvas_Wrap.G_planeDistance, PropertySetter = UnityEngine_Canvas_Wrap.S_planeDistance
#endif
                    }},
                    {"renderOrder", new MemberRegisterInfo { Name = "renderOrder", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_Canvas_Wrap.G_renderOrder
#endif
                    }},
                    {"overrideSorting", new MemberRegisterInfo { Name = "overrideSorting", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_Canvas_Wrap.G_overrideSorting, PropertySetter = UnityEngine_Canvas_Wrap.S_overrideSorting
#endif
                    }},
                    {"sortingOrder", new MemberRegisterInfo { Name = "sortingOrder", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_Canvas_Wrap.G_sortingOrder, PropertySetter = UnityEngine_Canvas_Wrap.S_sortingOrder
#endif
                    }},
                    {"targetDisplay", new MemberRegisterInfo { Name = "targetDisplay", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_Canvas_Wrap.G_targetDisplay, PropertySetter = UnityEngine_Canvas_Wrap.S_targetDisplay
#endif
                    }},
                    {"sortingLayerID", new MemberRegisterInfo { Name = "sortingLayerID", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_Canvas_Wrap.G_sortingLayerID, PropertySetter = UnityEngine_Canvas_Wrap.S_sortingLayerID
#endif
                    }},
                    {"cachedSortingLayerValue", new MemberRegisterInfo { Name = "cachedSortingLayerValue", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_Canvas_Wrap.G_cachedSortingLayerValue
#endif
                    }},
                    {"additionalShaderChannels", new MemberRegisterInfo { Name = "additionalShaderChannels", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_Canvas_Wrap.G_additionalShaderChannels, PropertySetter = UnityEngine_Canvas_Wrap.S_additionalShaderChannels
#endif
                    }},
                    {"sortingLayerName", new MemberRegisterInfo { Name = "sortingLayerName", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_Canvas_Wrap.G_sortingLayerName, PropertySetter = UnityEngine_Canvas_Wrap.S_sortingLayerName
#endif
                    }},
                    {"rootCanvas", new MemberRegisterInfo { Name = "rootCanvas", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_Canvas_Wrap.G_rootCanvas
#endif
                    }},
                    {"renderingDisplaySize", new MemberRegisterInfo { Name = "renderingDisplaySize", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_Canvas_Wrap.G_renderingDisplaySize
#endif
                    }},
                    {"worldCamera", new MemberRegisterInfo { Name = "worldCamera", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_Canvas_Wrap.G_worldCamera, PropertySetter = UnityEngine_Canvas_Wrap.S_worldCamera
#endif
                    }},
                    {"normalizedSortingGridSize", new MemberRegisterInfo { Name = "normalizedSortingGridSize", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_Canvas_Wrap.G_normalizedSortingGridSize, PropertySetter = UnityEngine_Canvas_Wrap.S_normalizedSortingGridSize
#endif
                    }},
                    {"GetDefaultCanvasMaterial_static", new MemberRegisterInfo { Name = "GetDefaultCanvasMaterial", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Canvas_Wrap.F_GetDefaultCanvasMaterial
#endif
                    }},
                    {"GetETC1SupportedCanvasMaterial_static", new MemberRegisterInfo { Name = "GetETC1SupportedCanvasMaterial", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Canvas_Wrap.F_GetETC1SupportedCanvasMaterial
#endif
                    }},
                    {"ForceUpdateCanvases_static", new MemberRegisterInfo { Name = "ForceUpdateCanvases", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Canvas_Wrap.F_ForceUpdateCanvases
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_UnityEngine_Behaviour_Wrap() 
        {
            return new RegisterInfo 
            {
#if !EXPERIMENTAL_IL2CPP_PUERTS
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {".ctor", new MemberRegisterInfo { Name = ".ctor", IsStatic = false, MemberType = MemberType.Constructor, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Constructor = UnityEngine_Behaviour_Wrap.Constructor
#endif
                    }},
                    {"enabled", new MemberRegisterInfo { Name = "enabled", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_Behaviour_Wrap.G_enabled, PropertySetter = UnityEngine_Behaviour_Wrap.S_enabled
#endif
                    }},
                    {"isActiveAndEnabled", new MemberRegisterInfo { Name = "isActiveAndEnabled", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_Behaviour_Wrap.G_isActiveAndEnabled
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_UnityEngine_MonoBehaviour_Wrap() 
        {
            return new RegisterInfo 
            {
#if !EXPERIMENTAL_IL2CPP_PUERTS
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {".ctor", new MemberRegisterInfo { Name = ".ctor", IsStatic = false, MemberType = MemberType.Constructor, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Constructor = UnityEngine_MonoBehaviour_Wrap.Constructor
#endif
                    }},
                    {"IsInvoking", new MemberRegisterInfo { Name = "IsInvoking", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_MonoBehaviour_Wrap.M_IsInvoking
#endif
                    }},
                    {"CancelInvoke", new MemberRegisterInfo { Name = "CancelInvoke", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_MonoBehaviour_Wrap.M_CancelInvoke
#endif
                    }},
                    {"Invoke", new MemberRegisterInfo { Name = "Invoke", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_MonoBehaviour_Wrap.M_Invoke
#endif
                    }},
                    {"InvokeRepeating", new MemberRegisterInfo { Name = "InvokeRepeating", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_MonoBehaviour_Wrap.M_InvokeRepeating
#endif
                    }},
                    {"StartCoroutine", new MemberRegisterInfo { Name = "StartCoroutine", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_MonoBehaviour_Wrap.M_StartCoroutine
#endif
                    }},
                    {"StopCoroutine", new MemberRegisterInfo { Name = "StopCoroutine", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_MonoBehaviour_Wrap.M_StopCoroutine
#endif
                    }},
                    {"StopAllCoroutines", new MemberRegisterInfo { Name = "StopAllCoroutines", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_MonoBehaviour_Wrap.M_StopAllCoroutines
#endif
                    }},
                    {"useGUILayout", new MemberRegisterInfo { Name = "useGUILayout", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_MonoBehaviour_Wrap.G_useGUILayout, PropertySetter = UnityEngine_MonoBehaviour_Wrap.S_useGUILayout
#endif
                    }},
                    {"runInEditMode", new MemberRegisterInfo { Name = "runInEditMode", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.SlowBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    
#endif
                    }},
                    {"print_static", new MemberRegisterInfo { Name = "print", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_MonoBehaviour_Wrap.F_print
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_UnityEngine_EventSystems_UIBehaviour_Wrap() 
        {
            return new RegisterInfo 
            {
#if !EXPERIMENTAL_IL2CPP_PUERTS
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {"IsActive", new MemberRegisterInfo { Name = "IsActive", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_EventSystems_UIBehaviour_Wrap.M_IsActive
#endif
                    }},
                    {"IsDestroyed", new MemberRegisterInfo { Name = "IsDestroyed", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_EventSystems_UIBehaviour_Wrap.M_IsDestroyed
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_UnityEngine_UI_Selectable_Wrap() 
        {
            return new RegisterInfo 
            {
#if !EXPERIMENTAL_IL2CPP_PUERTS
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {"IsInteractable", new MemberRegisterInfo { Name = "IsInteractable", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_UI_Selectable_Wrap.M_IsInteractable
#endif
                    }},
                    {"FindSelectable", new MemberRegisterInfo { Name = "FindSelectable", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_UI_Selectable_Wrap.M_FindSelectable
#endif
                    }},
                    {"FindSelectableOnLeft", new MemberRegisterInfo { Name = "FindSelectableOnLeft", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_UI_Selectable_Wrap.M_FindSelectableOnLeft
#endif
                    }},
                    {"FindSelectableOnRight", new MemberRegisterInfo { Name = "FindSelectableOnRight", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_UI_Selectable_Wrap.M_FindSelectableOnRight
#endif
                    }},
                    {"FindSelectableOnUp", new MemberRegisterInfo { Name = "FindSelectableOnUp", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_UI_Selectable_Wrap.M_FindSelectableOnUp
#endif
                    }},
                    {"FindSelectableOnDown", new MemberRegisterInfo { Name = "FindSelectableOnDown", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_UI_Selectable_Wrap.M_FindSelectableOnDown
#endif
                    }},
                    {"OnMove", new MemberRegisterInfo { Name = "OnMove", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_UI_Selectable_Wrap.M_OnMove
#endif
                    }},
                    {"OnPointerDown", new MemberRegisterInfo { Name = "OnPointerDown", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_UI_Selectable_Wrap.M_OnPointerDown
#endif
                    }},
                    {"OnPointerUp", new MemberRegisterInfo { Name = "OnPointerUp", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_UI_Selectable_Wrap.M_OnPointerUp
#endif
                    }},
                    {"OnPointerEnter", new MemberRegisterInfo { Name = "OnPointerEnter", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_UI_Selectable_Wrap.M_OnPointerEnter
#endif
                    }},
                    {"OnPointerExit", new MemberRegisterInfo { Name = "OnPointerExit", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_UI_Selectable_Wrap.M_OnPointerExit
#endif
                    }},
                    {"OnSelect", new MemberRegisterInfo { Name = "OnSelect", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_UI_Selectable_Wrap.M_OnSelect
#endif
                    }},
                    {"OnDeselect", new MemberRegisterInfo { Name = "OnDeselect", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_UI_Selectable_Wrap.M_OnDeselect
#endif
                    }},
                    {"Select", new MemberRegisterInfo { Name = "Select", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_UI_Selectable_Wrap.M_Select
#endif
                    }},
                    {"navigation", new MemberRegisterInfo { Name = "navigation", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_UI_Selectable_Wrap.G_navigation, PropertySetter = UnityEngine_UI_Selectable_Wrap.S_navigation
#endif
                    }},
                    {"transition", new MemberRegisterInfo { Name = "transition", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_UI_Selectable_Wrap.G_transition, PropertySetter = UnityEngine_UI_Selectable_Wrap.S_transition
#endif
                    }},
                    {"colors", new MemberRegisterInfo { Name = "colors", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_UI_Selectable_Wrap.G_colors, PropertySetter = UnityEngine_UI_Selectable_Wrap.S_colors
#endif
                    }},
                    {"spriteState", new MemberRegisterInfo { Name = "spriteState", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_UI_Selectable_Wrap.G_spriteState, PropertySetter = UnityEngine_UI_Selectable_Wrap.S_spriteState
#endif
                    }},
                    {"animationTriggers", new MemberRegisterInfo { Name = "animationTriggers", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_UI_Selectable_Wrap.G_animationTriggers, PropertySetter = UnityEngine_UI_Selectable_Wrap.S_animationTriggers
#endif
                    }},
                    {"targetGraphic", new MemberRegisterInfo { Name = "targetGraphic", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_UI_Selectable_Wrap.G_targetGraphic, PropertySetter = UnityEngine_UI_Selectable_Wrap.S_targetGraphic
#endif
                    }},
                    {"interactable", new MemberRegisterInfo { Name = "interactable", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_UI_Selectable_Wrap.G_interactable, PropertySetter = UnityEngine_UI_Selectable_Wrap.S_interactable
#endif
                    }},
                    {"image", new MemberRegisterInfo { Name = "image", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_UI_Selectable_Wrap.G_image, PropertySetter = UnityEngine_UI_Selectable_Wrap.S_image
#endif
                    }},
                    {"animator", new MemberRegisterInfo { Name = "animator", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_UI_Selectable_Wrap.G_animator
#endif
                    }},
                    {"AllSelectablesNoAlloc_static", new MemberRegisterInfo { Name = "AllSelectablesNoAlloc", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_UI_Selectable_Wrap.F_AllSelectablesNoAlloc
#endif
                    }},
                    {"allSelectablesArray_static", new MemberRegisterInfo { Name = "allSelectablesArray", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_UI_Selectable_Wrap.G_allSelectablesArray
#endif
                    }},
                    {"allSelectableCount_static", new MemberRegisterInfo { Name = "allSelectableCount", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_UI_Selectable_Wrap.G_allSelectableCount
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_UnityEngine_UI_Button_Wrap() 
        {
            return new RegisterInfo 
            {
#if !EXPERIMENTAL_IL2CPP_PUERTS
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {"OnPointerClick", new MemberRegisterInfo { Name = "OnPointerClick", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_UI_Button_Wrap.M_OnPointerClick
#endif
                    }},
                    {"OnSubmit", new MemberRegisterInfo { Name = "OnSubmit", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_UI_Button_Wrap.M_OnSubmit
#endif
                    }},
                    {"onClick", new MemberRegisterInfo { Name = "onClick", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_UI_Button_Wrap.G_onClick, PropertySetter = UnityEngine_UI_Button_Wrap.S_onClick
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_UnityEngine_Events_UnityEvent_Wrap() 
        {
            return new RegisterInfo 
            {
#if !EXPERIMENTAL_IL2CPP_PUERTS
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {".ctor", new MemberRegisterInfo { Name = ".ctor", IsStatic = false, MemberType = MemberType.Constructor, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Constructor = UnityEngine_Events_UnityEvent_Wrap.Constructor
#endif
                    }},
                    {"AddListener", new MemberRegisterInfo { Name = "AddListener", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Events_UnityEvent_Wrap.M_AddListener
#endif
                    }},
                    {"RemoveListener", new MemberRegisterInfo { Name = "RemoveListener", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Events_UnityEvent_Wrap.M_RemoveListener
#endif
                    }},
                    {"Invoke", new MemberRegisterInfo { Name = "Invoke", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_Events_UnityEvent_Wrap.M_Invoke
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_UnityEngine_UI_InputField_Wrap() 
        {
            return new RegisterInfo 
            {
#if !EXPERIMENTAL_IL2CPP_PUERTS
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {"SetTextWithoutNotify", new MemberRegisterInfo { Name = "SetTextWithoutNotify", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_UI_InputField_Wrap.M_SetTextWithoutNotify
#endif
                    }},
                    {"MoveTextEnd", new MemberRegisterInfo { Name = "MoveTextEnd", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_UI_InputField_Wrap.M_MoveTextEnd
#endif
                    }},
                    {"MoveTextStart", new MemberRegisterInfo { Name = "MoveTextStart", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_UI_InputField_Wrap.M_MoveTextStart
#endif
                    }},
                    {"OnBeginDrag", new MemberRegisterInfo { Name = "OnBeginDrag", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_UI_InputField_Wrap.M_OnBeginDrag
#endif
                    }},
                    {"OnDrag", new MemberRegisterInfo { Name = "OnDrag", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_UI_InputField_Wrap.M_OnDrag
#endif
                    }},
                    {"OnEndDrag", new MemberRegisterInfo { Name = "OnEndDrag", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_UI_InputField_Wrap.M_OnEndDrag
#endif
                    }},
                    {"OnPointerDown", new MemberRegisterInfo { Name = "OnPointerDown", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_UI_InputField_Wrap.M_OnPointerDown
#endif
                    }},
                    {"ProcessEvent", new MemberRegisterInfo { Name = "ProcessEvent", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_UI_InputField_Wrap.M_ProcessEvent
#endif
                    }},
                    {"OnUpdateSelected", new MemberRegisterInfo { Name = "OnUpdateSelected", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_UI_InputField_Wrap.M_OnUpdateSelected
#endif
                    }},
                    {"ForceLabelUpdate", new MemberRegisterInfo { Name = "ForceLabelUpdate", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_UI_InputField_Wrap.M_ForceLabelUpdate
#endif
                    }},
                    {"Rebuild", new MemberRegisterInfo { Name = "Rebuild", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_UI_InputField_Wrap.M_Rebuild
#endif
                    }},
                    {"LayoutComplete", new MemberRegisterInfo { Name = "LayoutComplete", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_UI_InputField_Wrap.M_LayoutComplete
#endif
                    }},
                    {"GraphicUpdateComplete", new MemberRegisterInfo { Name = "GraphicUpdateComplete", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_UI_InputField_Wrap.M_GraphicUpdateComplete
#endif
                    }},
                    {"ActivateInputField", new MemberRegisterInfo { Name = "ActivateInputField", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_UI_InputField_Wrap.M_ActivateInputField
#endif
                    }},
                    {"OnSelect", new MemberRegisterInfo { Name = "OnSelect", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_UI_InputField_Wrap.M_OnSelect
#endif
                    }},
                    {"OnPointerClick", new MemberRegisterInfo { Name = "OnPointerClick", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_UI_InputField_Wrap.M_OnPointerClick
#endif
                    }},
                    {"DeactivateInputField", new MemberRegisterInfo { Name = "DeactivateInputField", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_UI_InputField_Wrap.M_DeactivateInputField
#endif
                    }},
                    {"OnDeselect", new MemberRegisterInfo { Name = "OnDeselect", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_UI_InputField_Wrap.M_OnDeselect
#endif
                    }},
                    {"OnSubmit", new MemberRegisterInfo { Name = "OnSubmit", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_UI_InputField_Wrap.M_OnSubmit
#endif
                    }},
                    {"CalculateLayoutInputHorizontal", new MemberRegisterInfo { Name = "CalculateLayoutInputHorizontal", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_UI_InputField_Wrap.M_CalculateLayoutInputHorizontal
#endif
                    }},
                    {"CalculateLayoutInputVertical", new MemberRegisterInfo { Name = "CalculateLayoutInputVertical", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_UI_InputField_Wrap.M_CalculateLayoutInputVertical
#endif
                    }},
                    {"shouldHideMobileInput", new MemberRegisterInfo { Name = "shouldHideMobileInput", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_shouldHideMobileInput, PropertySetter = UnityEngine_UI_InputField_Wrap.S_shouldHideMobileInput
#endif
                    }},
                    {"shouldActivateOnSelect", new MemberRegisterInfo { Name = "shouldActivateOnSelect", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_shouldActivateOnSelect, PropertySetter = UnityEngine_UI_InputField_Wrap.S_shouldActivateOnSelect
#endif
                    }},
                    {"text", new MemberRegisterInfo { Name = "text", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_text, PropertySetter = UnityEngine_UI_InputField_Wrap.S_text
#endif
                    }},
                    {"isFocused", new MemberRegisterInfo { Name = "isFocused", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_isFocused
#endif
                    }},
                    {"caretBlinkRate", new MemberRegisterInfo { Name = "caretBlinkRate", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_caretBlinkRate, PropertySetter = UnityEngine_UI_InputField_Wrap.S_caretBlinkRate
#endif
                    }},
                    {"caretWidth", new MemberRegisterInfo { Name = "caretWidth", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_caretWidth, PropertySetter = UnityEngine_UI_InputField_Wrap.S_caretWidth
#endif
                    }},
                    {"textComponent", new MemberRegisterInfo { Name = "textComponent", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_textComponent, PropertySetter = UnityEngine_UI_InputField_Wrap.S_textComponent
#endif
                    }},
                    {"placeholder", new MemberRegisterInfo { Name = "placeholder", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_placeholder, PropertySetter = UnityEngine_UI_InputField_Wrap.S_placeholder
#endif
                    }},
                    {"caretColor", new MemberRegisterInfo { Name = "caretColor", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_caretColor, PropertySetter = UnityEngine_UI_InputField_Wrap.S_caretColor
#endif
                    }},
                    {"customCaretColor", new MemberRegisterInfo { Name = "customCaretColor", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_customCaretColor, PropertySetter = UnityEngine_UI_InputField_Wrap.S_customCaretColor
#endif
                    }},
                    {"selectionColor", new MemberRegisterInfo { Name = "selectionColor", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_selectionColor, PropertySetter = UnityEngine_UI_InputField_Wrap.S_selectionColor
#endif
                    }},
                    {"onEndEdit", new MemberRegisterInfo { Name = "onEndEdit", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_onEndEdit, PropertySetter = UnityEngine_UI_InputField_Wrap.S_onEndEdit
#endif
                    }},
                    {"onSubmit", new MemberRegisterInfo { Name = "onSubmit", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_onSubmit, PropertySetter = UnityEngine_UI_InputField_Wrap.S_onSubmit
#endif
                    }},
                    {"onValueChanged", new MemberRegisterInfo { Name = "onValueChanged", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_onValueChanged, PropertySetter = UnityEngine_UI_InputField_Wrap.S_onValueChanged
#endif
                    }},
                    {"onValidateInput", new MemberRegisterInfo { Name = "onValidateInput", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_onValidateInput, PropertySetter = UnityEngine_UI_InputField_Wrap.S_onValidateInput
#endif
                    }},
                    {"characterLimit", new MemberRegisterInfo { Name = "characterLimit", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_characterLimit, PropertySetter = UnityEngine_UI_InputField_Wrap.S_characterLimit
#endif
                    }},
                    {"contentType", new MemberRegisterInfo { Name = "contentType", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_contentType, PropertySetter = UnityEngine_UI_InputField_Wrap.S_contentType
#endif
                    }},
                    {"lineType", new MemberRegisterInfo { Name = "lineType", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_lineType, PropertySetter = UnityEngine_UI_InputField_Wrap.S_lineType
#endif
                    }},
                    {"inputType", new MemberRegisterInfo { Name = "inputType", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_inputType, PropertySetter = UnityEngine_UI_InputField_Wrap.S_inputType
#endif
                    }},
                    {"touchScreenKeyboard", new MemberRegisterInfo { Name = "touchScreenKeyboard", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_touchScreenKeyboard
#endif
                    }},
                    {"keyboardType", new MemberRegisterInfo { Name = "keyboardType", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_keyboardType, PropertySetter = UnityEngine_UI_InputField_Wrap.S_keyboardType
#endif
                    }},
                    {"characterValidation", new MemberRegisterInfo { Name = "characterValidation", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_characterValidation, PropertySetter = UnityEngine_UI_InputField_Wrap.S_characterValidation
#endif
                    }},
                    {"readOnly", new MemberRegisterInfo { Name = "readOnly", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_readOnly, PropertySetter = UnityEngine_UI_InputField_Wrap.S_readOnly
#endif
                    }},
                    {"multiLine", new MemberRegisterInfo { Name = "multiLine", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_multiLine
#endif
                    }},
                    {"asteriskChar", new MemberRegisterInfo { Name = "asteriskChar", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_asteriskChar, PropertySetter = UnityEngine_UI_InputField_Wrap.S_asteriskChar
#endif
                    }},
                    {"wasCanceled", new MemberRegisterInfo { Name = "wasCanceled", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_wasCanceled
#endif
                    }},
                    {"caretPosition", new MemberRegisterInfo { Name = "caretPosition", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_caretPosition, PropertySetter = UnityEngine_UI_InputField_Wrap.S_caretPosition
#endif
                    }},
                    {"selectionAnchorPosition", new MemberRegisterInfo { Name = "selectionAnchorPosition", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_selectionAnchorPosition, PropertySetter = UnityEngine_UI_InputField_Wrap.S_selectionAnchorPosition
#endif
                    }},
                    {"selectionFocusPosition", new MemberRegisterInfo { Name = "selectionFocusPosition", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_selectionFocusPosition, PropertySetter = UnityEngine_UI_InputField_Wrap.S_selectionFocusPosition
#endif
                    }},
                    {"minWidth", new MemberRegisterInfo { Name = "minWidth", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_minWidth
#endif
                    }},
                    {"preferredWidth", new MemberRegisterInfo { Name = "preferredWidth", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_preferredWidth
#endif
                    }},
                    {"flexibleWidth", new MemberRegisterInfo { Name = "flexibleWidth", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_flexibleWidth
#endif
                    }},
                    {"minHeight", new MemberRegisterInfo { Name = "minHeight", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_minHeight
#endif
                    }},
                    {"preferredHeight", new MemberRegisterInfo { Name = "preferredHeight", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_preferredHeight
#endif
                    }},
                    {"flexibleHeight", new MemberRegisterInfo { Name = "flexibleHeight", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_flexibleHeight
#endif
                    }},
                    {"layoutPriority", new MemberRegisterInfo { Name = "layoutPriority", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_UI_InputField_Wrap.G_layoutPriority
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_UnityEngine_UI_Toggle_Wrap() 
        {
            return new RegisterInfo 
            {
#if !EXPERIMENTAL_IL2CPP_PUERTS
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {"Rebuild", new MemberRegisterInfo { Name = "Rebuild", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_UI_Toggle_Wrap.M_Rebuild
#endif
                    }},
                    {"LayoutComplete", new MemberRegisterInfo { Name = "LayoutComplete", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_UI_Toggle_Wrap.M_LayoutComplete
#endif
                    }},
                    {"GraphicUpdateComplete", new MemberRegisterInfo { Name = "GraphicUpdateComplete", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_UI_Toggle_Wrap.M_GraphicUpdateComplete
#endif
                    }},
                    {"SetIsOnWithoutNotify", new MemberRegisterInfo { Name = "SetIsOnWithoutNotify", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_UI_Toggle_Wrap.M_SetIsOnWithoutNotify
#endif
                    }},
                    {"OnPointerClick", new MemberRegisterInfo { Name = "OnPointerClick", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_UI_Toggle_Wrap.M_OnPointerClick
#endif
                    }},
                    {"OnSubmit", new MemberRegisterInfo { Name = "OnSubmit", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , Method = UnityEngine_UI_Toggle_Wrap.M_OnSubmit
#endif
                    }},
                    {"group", new MemberRegisterInfo { Name = "group", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_UI_Toggle_Wrap.G_group, PropertySetter = UnityEngine_UI_Toggle_Wrap.S_group
#endif
                    }},
                    {"isOn", new MemberRegisterInfo { Name = "isOn", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_UI_Toggle_Wrap.G_isOn, PropertySetter = UnityEngine_UI_Toggle_Wrap.S_isOn
#endif
                    }},
                    {"toggleTransition", new MemberRegisterInfo { Name = "toggleTransition", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_UI_Toggle_Wrap.G_toggleTransition, PropertySetter = UnityEngine_UI_Toggle_Wrap.S_toggleTransition
#endif
                    }},
                    {"graphic", new MemberRegisterInfo { Name = "graphic", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_UI_Toggle_Wrap.G_graphic, PropertySetter = UnityEngine_UI_Toggle_Wrap.S_graphic
#endif
                    }},
                    {"onValueChanged", new MemberRegisterInfo { Name = "onValueChanged", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if !EXPERIMENTAL_IL2CPP_PUERTS
                    , PropertyGetter = UnityEngine_UI_Toggle_Wrap.G_onValueChanged, PropertySetter = UnityEngine_UI_Toggle_Wrap.S_onValueChanged
#endif
                    }},
                }
            };
        }

        public static void AddRegisterInfoGetterIntoJsEnv(JsEnv jsEnv)
        {
            
                jsEnv.AddRegisterInfoGetter(typeof(UnityEngine.Debug), GetRegisterInfo_UnityEngine_Debug_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(UnityEngine.Vector3), GetRegisterInfo_UnityEngine_Vector3_Wrap);
#if !EXPERIMENTAL_IL2CPP_PUERTS
                UnityEngine_Vector3_Wrap.InitBlittableCopy(jsEnv);                    
#endif
                jsEnv.AddRegisterInfoGetter(typeof(UnityEngine.Transform), GetRegisterInfo_UnityEngine_Transform_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(UnityEngine.Component), GetRegisterInfo_UnityEngine_Component_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(UnityEngine.GameObject), GetRegisterInfo_UnityEngine_GameObject_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(UnityEngine.Object), GetRegisterInfo_UnityEngine_Object_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(UnityEngine.ParticleSystem), GetRegisterInfo_UnityEngine_ParticleSystem_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(UnityEngine.Canvas), GetRegisterInfo_UnityEngine_Canvas_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(UnityEngine.Behaviour), GetRegisterInfo_UnityEngine_Behaviour_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(UnityEngine.MonoBehaviour), GetRegisterInfo_UnityEngine_MonoBehaviour_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(UnityEngine.EventSystems.UIBehaviour), GetRegisterInfo_UnityEngine_EventSystems_UIBehaviour_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(UnityEngine.UI.Selectable), GetRegisterInfo_UnityEngine_UI_Selectable_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(UnityEngine.UI.Button), GetRegisterInfo_UnityEngine_UI_Button_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(UnityEngine.Events.UnityEvent), GetRegisterInfo_UnityEngine_Events_UnityEvent_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(UnityEngine.UI.InputField), GetRegisterInfo_UnityEngine_UI_InputField_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(UnityEngine.UI.Toggle), GetRegisterInfo_UnityEngine_UI_Toggle_Wrap);
        }
    }
}