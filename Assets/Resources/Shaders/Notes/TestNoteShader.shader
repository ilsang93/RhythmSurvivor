Shader "Custom/TestNoteShader"
{
    Properties
    {
        _MainTex ("Albedo (RGB)", 2D) = "white" {}
        _MainTex2 ("Albedo (RGB)", 2D) = "white" {}
        _LerpTest ("Lerp Test", Range(0, 1)) = 0.5
    }
    SubShader
    {
        Tags { "RenderType"="Opaque" }

        CGPROGRAM
        #pragma surface surf Standard

        sampler2D _MainTex;
        sampler2D _MainTex2;

        struct Input
        {
            float2 uv_MainTex;
            float2 uv_MainTex2;
        };

        float _LerpTest;

        void surf (Input IN, inout SurfaceOutputStandard o)
        {
            fixed4 c = tex2D (_MainTex, IN.uv_MainTex * 3);
            fixed4 d = tex2D (_MainTex2, IN.uv_MainTex2);
            // o.Emission = float3(IN.uv_MainTex.x, IN.uv_MainTex.y, 0);
            o.Emission = lerp(c.rgb, d.rgb, 1 - c.a);
        }
        ENDCG
    }
    FallBack "Diffuse"
}
