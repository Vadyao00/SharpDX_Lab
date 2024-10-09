struct vertexData
{
	float4 position : POSITION;
	float4 color : COLOR;
};

struct pixelData
{
	float4 position : SV_POSITION;
    float4 color : COLOR;
    float4 worldPos : POSITION;
};

cbuffer perObjectData : register(b0) {
	float4x4 worldViewProjectionMatrix;
	float    time;
	int      timeScaling;
	float2   _padding;
}




pixelData vertexShader(vertexData input) {
	pixelData output = (pixelData)0;
	float4 position = input.position;

    float y = 2 * pow(position.x, 2)/30 - 2 * pow(position.z,2)/30;
	

	
    position.y = y;
    output.worldPos = position;
	
    output.color = float4(position.y / 5, 1, 1, 1);
	
	output.position =
		mul(position, worldViewProjectionMatrix);

	return output;
}