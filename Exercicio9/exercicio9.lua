tabela={}
for i=33,126 do
table.insert(tabela, string.char(i))
end
for k,v in ipairs(tabela) do
print(v)
end