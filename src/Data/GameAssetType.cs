using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLSS_Swapper.Data;

public enum GameAssetType
{
    Unknown,

    DLSS,
    DLSS_G,
    DLSS_D,
    FSR_31_DX12,
    FSR_31_VK,
    FSR_4_DX12,
    FSR_4_VK,  // Note: FSR 4 Vulkan support not yet available from AMD
    XeSS,
    XeLL,
    XeSS_FG,

    OPTISCALER_DX12,  // OptiScaler: Convert DLSS to FSR for AMD GPU compatibility
    OPTISCALER_VK,    // OptiScaler: Convert DLSS to FSR for AMD GPU compatibility

    DLSS_BACKUP,
    DLSS_G_BACKUP,
    DLSS_D_BACKUP,
    FSR_31_DX12_BACKUP,
    FSR_31_VK_BACKUP,
    FSR_4_DX12_BACKUP,
    FSR_4_VK_BACKUP,  // Note: FSR 4 Vulkan support not yet available from AMD
    XeSS_BACKUP,
    XeLL_BACKUP,
    XeSS_FG_BACKUP,

    OPTISCALER_DX12_BACKUP,  // OptiScaler backup for DLSS to FSR conversion
    OPTISCALER_VK_BACKUP,    // OptiScaler backup for DLSS to FSR conversion
}
