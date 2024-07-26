Shader "Custom/OutlineTilemapShader"
{
    Properties
    {
        _MainTex ("Tilemap Texture", 2D) = "white" {}
        _OutlineColor ("Outline Color", Color) = (0,0,0,1)
        _OutlineThickness ("Outline Thickness", Range(0.0, 0.1)) = 0.05
    }
    SubShader
    {
        Tags { "Queue" = "Overlay" }
        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag

            #include "UnityCG.cginc"

            struct appdata_t
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
            };

            struct v2f
            {
                float2 uv : TEXCOORD0;
                float4 vertex : SV_POSITION;
            };

            sampler2D _MainTex;
            float4 _OutlineColor;
            float _OutlineThickness;

            v2f vert (appdata_t v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = v.uv;
                return o;
            }

            float4 frag (v2f i) : SV_Target
            {
                float4 color = tex2D(_MainTex, i.uv);
                float2 uv = i.uv;

                float4 outlineColor = _OutlineColor;
                float thickness = _OutlineThickness;

                if (uv.x < thickness || uv.x > (1.0 - thickness) || uv.y < thickness || uv.y > (1.0 - thickness))
                {
                    return outlineColor;
                }

                return color;
            }
            ENDCG
        }
    }
}