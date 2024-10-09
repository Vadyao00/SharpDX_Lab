struct pixelData
{
	float4 position : SV_POSITION;
	float4 color : COLOR;
    float4 worldPos : POSITION;
};

float4 pixelShader(pixelData input) : SV_Target
{
    if(input.worldPos.y>2)
        clip(-1);
    return input.color;

}