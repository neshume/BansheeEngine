#pragma once

#include "CmD3D11Prerequisites.h"
#include "CmDepthStencilBuffer.h"

namespace CamelotEngine
{
	class CM_D3D11_EXPORT D3D11DepthStencilBuffer : public DepthStencilBuffer
	{
	public:
		D3D11DepthStencilBuffer(UINT32 bitDepth, UINT32 width, UINT32 height, UINT32 fsaa, const String &fsaaHint);
		~D3D11DepthStencilBuffer();

		bool isCompatible(RenderTarget* renderTarget) const;

	protected:
		ID3D11Texture2D* mDepthStencil;
		ID3D11DepthStencilView* mDepthStencilView;
	};
}