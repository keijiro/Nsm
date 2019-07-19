Shader "Nsm/Monitor"
{
    Properties
    {
        _MainTex("Texture", 2D) = "gray" {}
    }

    CGINCLUDE

    #include "UnityCG.cginc"

    sampler2D _MainTex;

    float4 Vertex(float4 position : POSITION) : SV_POSITION
    {
        return UnityObjectToClipPos(position);
    }

    float4 Fragment(float4 position : SV_POSITION) : SV_Target
    {
        // UV coordinates from clip space position
        float2 uv = position.xy * (_ScreenParams.zw - 1);
        uv.y = 1 - uv.y;

        // Color sample
        float4 s = tex2D(_MainTex, uv);

        // Checkerboard pattern
        const float checker_size = 40;
        float cp = (frac(position.x / checker_size) > 0.5) ^
                   (frac(position.y / checker_size) > 0.5);
        cp = lerp(0.2, 0.5, cp);

        return float4(lerp(cp, s.rgb, s.a), s.a);
    }

    ENDCG

    SubShader
    {
        Pass
        {
            CGPROGRAM
            #pragma vertex Vertex
            #pragma fragment Fragment
            ENDCG
        }
    }
}
