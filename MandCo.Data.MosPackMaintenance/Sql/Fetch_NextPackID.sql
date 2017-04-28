select LPAD((max(h1.pack_id) + 1), 5, '0') "Next_Pack_ID"
From   hir_pack_makeup h1
Where  h1.pack_id < 'S 0 1'