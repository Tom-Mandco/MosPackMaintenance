Select unique(pMakeup.Size_Code),
       refSize.Size_Description
From   hir_pack_makeup pMakeup,
       ref_size        refSize
Where  pMakeup.Pack_Id = '00358'
And    pMakeup.Size_Code = refSize.Size_Code