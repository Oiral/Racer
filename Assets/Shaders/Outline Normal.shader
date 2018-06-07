// Upgrade NOTE: replaced '_Object2World' with 'unity_ObjectToWorld'

// Shader created with Shader Forge v1.38 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:1,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:1,spxs:False,tesm:0,olmd:0,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:4013,x:33059,y:32706,varname:node_4013,prsc:2|diff-3082-OUT,emission-3082-OUT,olwid-3276-OUT,olcol-3235-RGB;n:type:ShaderForge.SFN_FragmentPosition,id:4762,x:32251,y:33184,varname:node_4762,prsc:2;n:type:ShaderForge.SFN_ViewPosition,id:6994,x:32251,y:33059,varname:node_6994,prsc:2;n:type:ShaderForge.SFN_Multiply,id:3276,x:32617,y:33220,varname:node_3276,prsc:2|A-7574-OUT,B-9345-OUT;n:type:ShaderForge.SFN_Slider,id:9345,x:32335,y:33382,ptovrint:False,ptlb:node_9345,ptin:_node_9345,varname:node_9345,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.01282051,max:0.5;n:type:ShaderForge.SFN_Distance,id:7574,x:32452,y:33124,varname:node_7574,prsc:2|A-6994-XYZ,B-4762-XYZ;n:type:ShaderForge.SFN_Color,id:3235,x:32799,y:33259,ptovrint:False,ptlb:Outline Color,ptin:_OutlineColor,varname:node_3235,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0,c2:0,c3:0,c4:1;n:type:ShaderForge.SFN_Slider,id:3132,x:33018,y:33288,ptovrint:False,ptlb:Outline Width,ptin:_OutlineWidth,varname:node_3132,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1,max:1;n:type:ShaderForge.SFN_Color,id:3669,x:33083,y:32493,ptovrint:False,ptlb:Base Color,ptin:_BaseColor,varname:node_3669,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.5,c2:0.5,c3:0.5,c4:1;n:type:ShaderForge.SFN_NormalVector,id:9768,x:32290,y:32545,prsc:2,pt:False;n:type:ShaderForge.SFN_Abs,id:3116,x:32457,y:32545,varname:node_3116,prsc:2|IN-9768-OUT;n:type:ShaderForge.SFN_Multiply,id:8885,x:32642,y:32545,varname:node_8885,prsc:2|A-3116-OUT,B-3116-OUT;n:type:ShaderForge.SFN_FragmentPosition,id:1845,x:32262,y:32740,varname:node_1845,prsc:2;n:type:ShaderForge.SFN_Append,id:7826,x:32497,y:32740,varname:node_7826,prsc:2|A-1845-Y,B-1845-Z;n:type:ShaderForge.SFN_Append,id:1830,x:32497,y:32983,varname:node_1830,prsc:2|A-1845-X,B-1845-Y;n:type:ShaderForge.SFN_Append,id:9709,x:32497,y:32860,varname:node_9709,prsc:2|A-1845-X,B-1845-Z;n:type:ShaderForge.SFN_Tex2d,id:1704,x:32688,y:32710,ptovrint:False,ptlb:R Tex,ptin:_RTex,varname:node_1704,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False|UVIN-7826-OUT;n:type:ShaderForge.SFN_Tex2d,id:2504,x:32688,y:32890,ptovrint:False,ptlb:G Tex,ptin:_GTex,varname:_node_1704_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False|UVIN-9709-OUT;n:type:ShaderForge.SFN_Tex2d,id:3521,x:32688,y:33066,ptovrint:False,ptlb:B Tex,ptin:_BTex,varname:_node_1704_copy_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False|UVIN-1830-OUT;n:type:ShaderForge.SFN_ChannelBlend,id:3082,x:32895,y:32765,varname:node_3082,prsc:2,chbt:0|M-8885-OUT,R-1704-RGB,G-2504-RGB,B-3521-RGB;proporder:9345-3235-3132-3669-1704-2504-3521;pass:END;sub:END;*/

Shader "Shader Forge/Outline Normal" {
    Properties {
        _node_9345 ("node_9345", Range(0, 0.5)) = 0.01282051
        _OutlineColor ("Outline Color", Color) = (0,0,0,1)
        _OutlineWidth ("Outline Width", Range(0, 1)) = 1
        _BaseColor ("Base Color", Color) = (0.5,0.5,0.5,1)
        _RTex ("R Tex", 2D) = "white" {}
        _GTex ("G Tex", 2D) = "white" {}
        _BTex ("B Tex", 2D) = "white" {}
    }
    SubShader {
        Tags {
            "RenderType"="Opaque"
        }
        Pass {
            Name "Outline"
            Tags {
            }
            Cull Front
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #include "UnityCG.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform float _node_9345;
            uniform float4 _OutlineColor;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float4 posWorld : TEXCOORD0;
                UNITY_FOG_COORDS(1)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = UnityObjectToClipPos( float4(v.vertex.xyz + normalize(v.vertex)*(distance(_WorldSpaceCameraPos,mul(unity_ObjectToWorld, v.vertex).rgb)*_node_9345),1) );
                UNITY_TRANSFER_FOG(o,o.pos);
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                return fixed4(_OutlineColor.rgb,0);
            }
            ENDCG
        }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #pragma multi_compile_fwdbase_fullshadows
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform float4 _LightColor0;
            uniform sampler2D _RTex; uniform float4 _RTex_ST;
            uniform sampler2D _GTex; uniform float4 _GTex_ST;
            uniform sampler2D _BTex; uniform float4 _BTex_ST;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float4 posWorld : TEXCOORD0;
                float3 normalDir : TEXCOORD1;
                LIGHTING_COORDS(2,3)
                UNITY_FOG_COORDS(4)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3 normalDirection = i.normalDir;
                float3 lightDirection = normalize(_WorldSpaceLightPos0.xyz);
                float3 lightColor = _LightColor0.rgb;
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 attenColor = attenuation * _LightColor0.xyz;
/////// Diffuse:
                float NdotL = max(0.0,dot( normalDirection, lightDirection ));
                float3 directDiffuse = max( 0.0, NdotL) * attenColor;
                float3 indirectDiffuse = float3(0,0,0);
                indirectDiffuse += UNITY_LIGHTMODEL_AMBIENT.rgb; // Ambient Light
                float3 node_3116 = abs(i.normalDir);
                float3 node_8885 = (node_3116*node_3116);
                float2 node_7826 = float2(i.posWorld.g,i.posWorld.b);
                float4 _RTex_var = tex2D(_RTex,TRANSFORM_TEX(node_7826, _RTex));
                float2 node_9709 = float2(i.posWorld.r,i.posWorld.b);
                float4 _GTex_var = tex2D(_GTex,TRANSFORM_TEX(node_9709, _GTex));
                float2 node_1830 = float2(i.posWorld.r,i.posWorld.g);
                float4 _BTex_var = tex2D(_BTex,TRANSFORM_TEX(node_1830, _BTex));
                float3 node_3082 = (node_8885.r*_RTex_var.rgb + node_8885.g*_GTex_var.rgb + node_8885.b*_BTex_var.rgb);
                float3 diffuseColor = node_3082;
                float3 diffuse = (directDiffuse + indirectDiffuse) * diffuseColor;
////// Emissive:
                float3 emissive = node_3082;
/// Final Color:
                float3 finalColor = diffuse + emissive;
                fixed4 finalRGBA = fixed4(finalColor,1);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
        Pass {
            Name "FORWARD_DELTA"
            Tags {
                "LightMode"="ForwardAdd"
            }
            Blend One One
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDADD
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #pragma multi_compile_fwdadd_fullshadows
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform float4 _LightColor0;
            uniform sampler2D _RTex; uniform float4 _RTex_ST;
            uniform sampler2D _GTex; uniform float4 _GTex_ST;
            uniform sampler2D _BTex; uniform float4 _BTex_ST;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float4 posWorld : TEXCOORD0;
                float3 normalDir : TEXCOORD1;
                LIGHTING_COORDS(2,3)
                UNITY_FOG_COORDS(4)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3 normalDirection = i.normalDir;
                float3 lightDirection = normalize(lerp(_WorldSpaceLightPos0.xyz, _WorldSpaceLightPos0.xyz - i.posWorld.xyz,_WorldSpaceLightPos0.w));
                float3 lightColor = _LightColor0.rgb;
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 attenColor = attenuation * _LightColor0.xyz;
/////// Diffuse:
                float NdotL = max(0.0,dot( normalDirection, lightDirection ));
                float3 directDiffuse = max( 0.0, NdotL) * attenColor;
                float3 node_3116 = abs(i.normalDir);
                float3 node_8885 = (node_3116*node_3116);
                float2 node_7826 = float2(i.posWorld.g,i.posWorld.b);
                float4 _RTex_var = tex2D(_RTex,TRANSFORM_TEX(node_7826, _RTex));
                float2 node_9709 = float2(i.posWorld.r,i.posWorld.b);
                float4 _GTex_var = tex2D(_GTex,TRANSFORM_TEX(node_9709, _GTex));
                float2 node_1830 = float2(i.posWorld.r,i.posWorld.g);
                float4 _BTex_var = tex2D(_BTex,TRANSFORM_TEX(node_1830, _BTex));
                float3 node_3082 = (node_8885.r*_RTex_var.rgb + node_8885.g*_GTex_var.rgb + node_8885.b*_BTex_var.rgb);
                float3 diffuseColor = node_3082;
                float3 diffuse = directDiffuse * diffuseColor;
/// Final Color:
                float3 finalColor = diffuse;
                fixed4 finalRGBA = fixed4(finalColor * 1,0);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
