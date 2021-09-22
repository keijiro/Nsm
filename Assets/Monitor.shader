Shader "Nsm/Monitor"
{
    Properties
    {
        _MainTex("Texture", 2D) = "gray" {}
    }

    CGINCLUDE

    #include "UnityCG.cginc"

    sampler2D _MainTex;

    void Vertex(float4 position : POSITION,
                float2 texCoord : TEXCOORD0,
                out float4 outPosition : SV_Position,
                out float2 outTexCoord : TEXCOORD0)
    {
        outPosition = UnityObjectToClipPos(position);
        outTexCoord = texCoord;
    }

    float4 Fragment(float4 position : SV_Position,
                    float2 texCoord : TEXCOORD0) : SV_Target
    {
        // Color sample
        float4 s = tex2D(_MainTex, texCoord);

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
