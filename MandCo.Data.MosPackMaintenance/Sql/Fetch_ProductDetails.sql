Select Unique(packMatch.product_number),
              product.product_description
From  war_hir_pack_match    packMatch,
      ref_product       product
Where packMatch.pack_id = '00358'
And   packMatch.product_number = product.product_number
Order by packMatch.product_number Asc