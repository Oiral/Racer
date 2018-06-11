// Upgrade NOTE: replaced '_Object2World' with 'unity_ObjectToWorld'

// Shader created with Shader Forge v1.38 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:3,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:1,spxs:False,tesm:0,olmd:0,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:4013,x:33059,y:32706,varname:node_4013,prsc:2|diff-3082-OUT,spec-111-OUT,gloss-9367-OUT,normal-4965-OUT,emission-3082-OUT,olwid-3276-OUT,olcol-3235-RGB;n:type:ShaderForge.SFN_FragmentPosition,id:4762,x:32103,y:33633,varname:node_4762,prsc:2;n:type:ShaderForge.SFN_ViewPosition,id:6994,x:32103,y:33508,varname:node_6994,prsc:2;n:type:ShaderForge.SFN_Multiply,id:3276,x:32469,y:33669,varname:node_3276,prsc:2|A-7574-OUT,B-9345-OUT;n:type:ShaderForge.SFN_Slider,id:9345,x:32187,y:33831,ptovrint:False,ptlb:Outline Width,ptin:_OutlineWidth,varname:_OutlineWidth,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.01282051,max:0.5;n:type:ShaderForge.SFN_Distance,id:7574,x:32304,y:33573,varname:node_7574,prsc:2|A-6994-XYZ,B-4762-XYZ;n:type:ShaderForge.SFN_Color,id:3235,x:32622,y:33634,ptovrint:False,ptlb:Outline Color,ptin:_OutlineColor,varname:_OutlineColor,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0,c2:0,c3:0,c4:1;n:type:ShaderForge.SFN_NormalVector,id:9768,x:31610,y:32792,prsc:2,pt:False;n:type:ShaderForge.SFN_Abs,id:3116,x:31772,y:32792,varname:node_3116,prsc:2|IN-9768-OUT;n:type:ShaderForge.SFN_Multiply,id:8885,x:31941,y:32792,varname:node_8885,prsc:2|A-3116-OUT,B-3116-OUT;n:type:ShaderForge.SFN_FragmentPosition,id:1845,x:31753,y:32491,varname:node_1845,prsc:2;n:type:ShaderForge.SFN_Append,id:7826,x:31938,y:32342,varname:node_7826,prsc:2|A-1845-Y,B-1845-Z;n:type:ShaderForge.SFN_Append,id:1830,x:31938,y:32657,varname:node_1830,prsc:2|A-1845-X,B-1845-Y;n:type:ShaderForge.SFN_Append,id:9709,x:31938,y:32491,varname:node_9709,prsc:2|A-1845-X,B-1845-Z;n:type:ShaderForge.SFN_Tex2d,id:1704,x:32402,y:32103,varname:node_1704,prsc:2,ntxv:0,isnm:False|UVIN-7826-OUT,TEX-7503-TEX;n:type:ShaderForge.SFN_Tex2d,id:2504,x:32402,y:32227,varname:_node_1704_copy,prsc:2,ntxv:0,isnm:False|UVIN-9709-OUT,TEX-7503-TEX;n:type:ShaderForge.SFN_Tex2d,id:3521,x:32402,y:32359,varname:_node_1704_copy_copy,prsc:2,ntxv:0,isnm:False|UVIN-1830-OUT,TEX-7503-TEX;n:type:ShaderForge.SFN_ChannelBlend,id:3082,x:32610,y:32238,cmnt:Tileable World Space Textures,varname:node_3082,prsc:2,chbt:0|M-8885-OUT,R-1704-RGB,G-2504-RGB,B-3521-RGB;n:type:ShaderForge.SFN_ChannelBlend,id:111,x:32638,y:32626,varname:node_111,prsc:2,chbt:0|M-8885-OUT,R-9184-R,G-8763-R,B-2021-R;n:type:ShaderForge.SFN_Tex2dAsset,id:7503,x:32211,y:32297,ptovrint:False,ptlb:Base,ptin:_Base,varname:_Base,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Tex2d,id:8763,x:32399,y:32674,varname:_node_1706,prsc:2,ntxv:0,isnm:False|UVIN-9709-OUT,TEX-8201-TEX;n:type:ShaderForge.SFN_Tex2d,id:2021,x:32399,y:32833,varname:_node_1707,prsc:2,ntxv:0,isnm:False|UVIN-7826-OUT,TEX-8201-TEX;n:type:ShaderForge.SFN_Tex2d,id:9184,x:32399,y:32519,varname:node_1705,prsc:2,ntxv:0,isnm:False|UVIN-1830-OUT,TEX-8201-TEX;n:type:ShaderForge.SFN_Tex2dAsset,id:8201,x:32203,y:32684,ptovrint:False,ptlb:Metallic,ptin:_Metallic,varname:_Metallic,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Tex2d,id:5019,x:32399,y:33314,varname:Normalxz,prsc:2,ntxv:0,isnm:False|UVIN-1830-OUT,TEX-1334-TEX;n:type:ShaderForge.SFN_Tex2dAsset,id:1334,x:32196,y:33118,ptovrint:False,ptlb:Normal,ptin:_Normal,varname:_Normal,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Tex2d,id:4742,x:32399,y:33154,varname:Noramlyz,prsc:2,ntxv:0,isnm:False|UVIN-9709-OUT,TEX-1334-TEX;n:type:ShaderForge.SFN_Tex2d,id:6048,x:32399,y:32993,varname:Normalxy,prsc:2,ntxv:0,isnm:False|UVIN-7826-OUT,TEX-1334-TEX;n:type:ShaderForge.SFN_ChannelBlend,id:4965,x:32636,y:33154,varname:node_4965,prsc:2,chbt:0|M-8885-OUT,R-6048-RGB,G-4742-RGB,B-5019-RGB;n:type:ShaderForge.SFN_ChannelBlend,id:9367,x:32638,y:32773,varname:node_9367,prsc:2,chbt:0|M-8885-OUT,R-9184-A,G-8763-A,B-2021-A;proporder:9345-3235-7503-8201-1334;pass:END;sub:END;*/

Shader "Shader Forge/Outline World Normal" {
    Properties {
        _OutlineWidth ("Outline Width", Range(0, 0.5)) = 0.01282051
        _OutlineColor ("Outline Color", Color) = (0,0,0,1)
        _Base ("Base", 2D) = "white" {}
        _Metallic ("Metallic", 2D) = "white" {}
        _Normal ("Normal", 2D) = "white" {}
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
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform float _OutlineWidth;
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
                o.pos = UnityObjectToClipPos( float4(v.vertex.xyz + normalize(v.vertex)*(distance(_WorldSpaceCameraPos,mul(unity_ObjectToWorld, v.vertex).rgb)*_OutlineWidth),1) );
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
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma multi_compile_fwdbase_fullshadows
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform sampler2D _Base; uniform float4 _Base_ST;
            uniform sampler2D _Metallic; uniform float4 _Metallic_ST;
            uniform sampler2D _Normal; uniform float4 _Normal_ST;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float4 posWorld : TEXCOORD0;
                float3 normalDir : TEXCOORD1;
                float3 tangentDir : TEXCOORD2;
                float3 bitangentDir : TEXCOORD3;
                LIGHTING_COORDS(4,5)
                UNITY_FOG_COORDS(6)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.tangentDir = normalize( mul( unity_ObjectToWorld, float4( v.tangent.xyz, 0.0 ) ).xyz );
                o.bitangentDir = normalize(cross(o.normalDir, o.tangentDir) * v.tangent.w);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 node_3116 = abs(i.normalDir);
                float3 node_8885 = (node_3116*node_3116);
                float2 node_7826 = float2(i.posWorld.g,i.posWorld.b);
                float4 Normalxy = tex2D(_Normal,TRANSFORM_TEX(node_7826, _Normal));
                float2 node_9709 = float2(i.posWorld.r,i.posWorld.b);
                float4 Noramlyz = tex2D(_Normal,TRANSFORM_TEX(node_9709, _Normal));
                float2 node_1830 = float2(i.posWorld.r,i.posWorld.g);
                float4 Normalxz = tex2D(_Normal,TRANSFORM_TEX(node_1830, _Normal));
                float3 normalLocal = (node_8885.r*Normalxy.rgb + node_8885.g*Noramlyz.rgb + node_8885.b*Normalxz.rgb);
                float3 normalDirection = normalize(mul( normalLocal, tangentTransform )); // Perturbed normals
                float3 viewReflectDirection = reflect( -viewDirection, normalDirection );
                float3 lightDirection = normalize(_WorldSpaceLightPos0.xyz);
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 attenColor = attenuation * _LightColor0.xyz;
                float Pi = 3.141592654;
                float InvPi = 0.31830988618;
///////// Gloss:
                float4 node_1705 = tex2D(_Metallic,TRANSFORM_TEX(node_1830, _Metallic));
                float4 _node_1706 = tex2D(_Metallic,TRANSFORM_TEX(node_9709, _Metallic));
                float4 _node_1707 = tex2D(_Metallic,TRANSFORM_TEX(node_7826, _Metallic));
                float gloss = (node_8885.r*node_1705.a + node_8885.g*_node_1706.a + node_8885.b*_node_1707.a);
                float perceptualRoughness = 1.0 - (node_8885.r*node_1705.a + node_8885.g*_node_1706.a + node_8885.b*_node_1707.a);
                float roughness = perceptualRoughness * perceptualRoughness;
                float specPow = exp2( gloss * 10.0 + 1.0 );
/////// GI Data:
                UnityLight light;
                #ifdef LIGHTMAP_OFF
                    light.color = lightColor;
                    light.dir = lightDirection;
                    light.ndotl = LambertTerm (normalDirection, light.dir);
                #else
                    light.color = half3(0.f, 0.f, 0.f);
                    light.ndotl = 0.0f;
                    light.dir = half3(0.f, 0.f, 0.f);
                #endif
                UnityGIInput d;
                d.light = light;
                d.worldPos = i.posWorld.xyz;
                d.worldViewDir = viewDirection;
                d.atten = attenuation;
                Unity_GlossyEnvironmentData ugls_en_data;
                ugls_en_data.roughness = 1.0 - gloss;
                ugls_en_data.reflUVW = viewReflectDirection;
                UnityGI gi = UnityGlobalIllumination(d, 1, normalDirection, ugls_en_data );
                lightDirection = gi.light.dir;
                lightColor = gi.light.color;
////// Specular:
                float NdotL = saturate(dot( normalDirection, lightDirection ));
                float LdotH = saturate(dot(lightDirection, halfDirection));
                float3 specularColor = (node_8885.r*node_1705.r + node_8885.g*_node_1706.r + node_8885.b*_node_1707.r);
                float specularMonochrome;
                float4 node_1704 = tex2D(_Base,TRANSFORM_TEX(node_7826, _Base));
                float4 _node_1704_copy = tex2D(_Base,TRANSFORM_TEX(node_9709, _Base));
                float4 _node_1704_copy_copy = tex2D(_Base,TRANSFORM_TEX(node_1830, _Base));
                float3 node_3082 = (node_8885.r*node_1704.rgb + node_8885.g*_node_1704_copy.rgb + node_8885.b*_node_1704_copy_copy.rgb); // Tileable World Space Textures
                float3 diffuseColor = node_3082; // Need this for specular when using metallic
                diffuseColor = DiffuseAndSpecularFromMetallic( diffuseColor, specularColor, specularColor, specularMonochrome );
                specularMonochrome = 1.0-specularMonochrome;
                float NdotV = abs(dot( normalDirection, viewDirection ));
                float NdotH = saturate(dot( normalDirection, halfDirection ));
                float VdotH = saturate(dot( viewDirection, halfDirection ));
                float visTerm = SmithJointGGXVisibilityTerm( NdotL, NdotV, roughness );
                float normTerm = GGXTerm(NdotH, roughness);
                float specularPBL = (visTerm*normTerm) * UNITY_PI;
                #ifdef UNITY_COLORSPACE_GAMMA
                    specularPBL = sqrt(max(1e-4h, specularPBL));
                #endif
                specularPBL = max(0, specularPBL * NdotL);
                #if defined(_SPECULARHIGHLIGHTS_OFF)
                    specularPBL = 0.0;
                #endif
                specularPBL *= any(specularColor) ? 1.0 : 0.0;
                float3 directSpecular = attenColor*specularPBL*FresnelTerm(specularColor, LdotH);
                float3 specular = directSpecular;
/////// Diffuse:
                NdotL = max(0.0,dot( normalDirection, lightDirection ));
                half fd90 = 0.5 + 2 * LdotH * LdotH * (1-gloss);
                float nlPow5 = Pow5(1-NdotL);
                float nvPow5 = Pow5(1-NdotV);
                float3 directDiffuse = ((1 +(fd90 - 1)*nlPow5) * (1 + (fd90 - 1)*nvPow5) * NdotL) * attenColor;
                float3 indirectDiffuse = float3(0,0,0);
                indirectDiffuse += UNITY_LIGHTMODEL_AMBIENT.rgb; // Ambient Light
                float3 diffuse = (directDiffuse + indirectDiffuse) * diffuseColor;
////// Emissive:
                float3 emissive = node_3082;
/// Final Color:
                float3 finalColor = diffuse + specular + emissive;
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
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma multi_compile_fwdadd_fullshadows
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform sampler2D _Base; uniform float4 _Base_ST;
            uniform sampler2D _Metallic; uniform float4 _Metallic_ST;
            uniform sampler2D _Normal; uniform float4 _Normal_ST;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float4 posWorld : TEXCOORD0;
                float3 normalDir : TEXCOORD1;
                float3 tangentDir : TEXCOORD2;
                float3 bitangentDir : TEXCOORD3;
                LIGHTING_COORDS(4,5)
                UNITY_FOG_COORDS(6)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.tangentDir = normalize( mul( unity_ObjectToWorld, float4( v.tangent.xyz, 0.0 ) ).xyz );
                o.bitangentDir = normalize(cross(o.normalDir, o.tangentDir) * v.tangent.w);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 node_3116 = abs(i.normalDir);
                float3 node_8885 = (node_3116*node_3116);
                float2 node_7826 = float2(i.posWorld.g,i.posWorld.b);
                float4 Normalxy = tex2D(_Normal,TRANSFORM_TEX(node_7826, _Normal));
                float2 node_9709 = float2(i.posWorld.r,i.posWorld.b);
                float4 Noramlyz = tex2D(_Normal,TRANSFORM_TEX(node_9709, _Normal));
                float2 node_1830 = float2(i.posWorld.r,i.posWorld.g);
                float4 Normalxz = tex2D(_Normal,TRANSFORM_TEX(node_1830, _Normal));
                float3 normalLocal = (node_8885.r*Normalxy.rgb + node_8885.g*Noramlyz.rgb + node_8885.b*Normalxz.rgb);
                float3 normalDirection = normalize(mul( normalLocal, tangentTransform )); // Perturbed normals
                float3 lightDirection = normalize(lerp(_WorldSpaceLightPos0.xyz, _WorldSpaceLightPos0.xyz - i.posWorld.xyz,_WorldSpaceLightPos0.w));
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 attenColor = attenuation * _LightColor0.xyz;
                float Pi = 3.141592654;
                float InvPi = 0.31830988618;
///////// Gloss:
                float4 node_1705 = tex2D(_Metallic,TRANSFORM_TEX(node_1830, _Metallic));
                float4 _node_1706 = tex2D(_Metallic,TRANSFORM_TEX(node_9709, _Metallic));
                float4 _node_1707 = tex2D(_Metallic,TRANSFORM_TEX(node_7826, _Metallic));
                float gloss = (node_8885.r*node_1705.a + node_8885.g*_node_1706.a + node_8885.b*_node_1707.a);
                float perceptualRoughness = 1.0 - (node_8885.r*node_1705.a + node_8885.g*_node_1706.a + node_8885.b*_node_1707.a);
                float roughness = perceptualRoughness * perceptualRoughness;
                float specPow = exp2( gloss * 10.0 + 1.0 );
////// Specular:
                float NdotL = saturate(dot( normalDirection, lightDirection ));
                float LdotH = saturate(dot(lightDirection, halfDirection));
                float3 specularColor = (node_8885.r*node_1705.r + node_8885.g*_node_1706.r + node_8885.b*_node_1707.r);
                float specularMonochrome;
                float4 node_1704 = tex2D(_Base,TRANSFORM_TEX(node_7826, _Base));
                float4 _node_1704_copy = tex2D(_Base,TRANSFORM_TEX(node_9709, _Base));
                float4 _node_1704_copy_copy = tex2D(_Base,TRANSFORM_TEX(node_1830, _Base));
                float3 node_3082 = (node_8885.r*node_1704.rgb + node_8885.g*_node_1704_copy.rgb + node_8885.b*_node_1704_copy_copy.rgb); // Tileable World Space Textures
                float3 diffuseColor = node_3082; // Need this for specular when using metallic
                diffuseColor = DiffuseAndSpecularFromMetallic( diffuseColor, specularColor, specularColor, specularMonochrome );
                specularMonochrome = 1.0-specularMonochrome;
                float NdotV = abs(dot( normalDirection, viewDirection ));
                float NdotH = saturate(dot( normalDirection, halfDirection ));
                float VdotH = saturate(dot( viewDirection, halfDirection ));
                float visTerm = SmithJointGGXVisibilityTerm( NdotL, NdotV, roughness );
                float normTerm = GGXTerm(NdotH, roughness);
                float specularPBL = (visTerm*normTerm) * UNITY_PI;
                #ifdef UNITY_COLORSPACE_GAMMA
                    specularPBL = sqrt(max(1e-4h, specularPBL));
                #endif
                specularPBL = max(0, specularPBL * NdotL);
                #if defined(_SPECULARHIGHLIGHTS_OFF)
                    specularPBL = 0.0;
                #endif
                specularPBL *= any(specularColor) ? 1.0 : 0.0;
                float3 directSpecular = attenColor*specularPBL*FresnelTerm(specularColor, LdotH);
                float3 specular = directSpecular;
/////// Diffuse:
                NdotL = max(0.0,dot( normalDirection, lightDirection ));
                half fd90 = 0.5 + 2 * LdotH * LdotH * (1-gloss);
                float nlPow5 = Pow5(1-NdotL);
                float nvPow5 = Pow5(1-NdotV);
                float3 directDiffuse = ((1 +(fd90 - 1)*nlPow5) * (1 + (fd90 - 1)*nvPow5) * NdotL) * attenColor;
                float3 diffuse = directDiffuse * diffuseColor;
/// Final Color:
                float3 finalColor = diffuse + specular;
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
