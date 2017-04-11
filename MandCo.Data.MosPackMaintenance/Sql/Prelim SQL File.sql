Select   hpn.pack_name "Pack Name",
         hpn.pack_id "Pack Id",
         whpm.pack_code "Pack Code",
         hpm.display_sequence "Display Sequence",
         p.product_number "Product Number",
         p.product_description "Product Description",
         hpn.no_of_sizes "Number of Sizes",
         hpm.size_code "Size Code",
         s.size_description "Size Description",
         hpn.no_of_units "No of Units",
         hpm.units_qty "Qty of Units",
         (hpn.no_of_units * hpm.units_qty) "Total units ordered"
From     hir_pack_names hpn,
         hir_pack_makeup hpm,
         war_hir_pack_match whpm,
         Ref_Size s,
         Ref_Product p
Where    whpm.pack_id = hpn.pack_id
And      whpm.pack_id = hpm.pack_id
And      hpm.size_code = s.size_code
And      whpm.product_number = p.product_number
And      whpm.product_number = 1000802
Order by whpm.product_number, hpm.pack_id, whpm.pack_code, hpm.display_sequence asc
