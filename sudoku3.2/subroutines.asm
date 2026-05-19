
.code

Bitscanr proc

mov rdx,rcx
bsr rax,rdx
inc rax
ret

Bitscanr endp
;_____________________

Copymem proc

mov rdi,rcx
mov rsi,rdx
mov rcx,81
rep movsb
ret

Copymem endp
;_____________________

Zeromem proc

mov rdi,rcx
xor rax,rax
mov rcx,rdx
rep stosb
ret

Zeromem endp

end
