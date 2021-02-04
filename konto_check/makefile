LIB_MAJOR_VERSION = 6
LIB_MINOR_VERSION = 13
LIB_PATCHLEVEL    = 0
LIB_VERSION = $(LIB_MAJOR_VERSION).$(LIB_MINOR_VERSION).$(LIB_PATCHLEVEL)

CFLAGS = -Wformat -Werror=format-security -DDEBUG=1 -g -O3 -fexpensive-optimizations -funroll-loops
LDFLAGS = -lz -s

lib: libkonto_check.so.$(LIB_VERSION)
libkonto_check.so.$(LIB_VERSION): konto_check.c konto_check.h retvals.h
	gcc -fPIC -c $(CFLAGS) konto_check.c
	gcc -shared -Wl,-soname,libkonto_check.so.$(LIB_VERSION) -o libkonto_check.so.$(LIB_VERSION) konto_check.o -lz -s

libkonto_check: libkonto_check.so
libkonto_check.so: konto_check.c konto_check.h retvals.h
	gcc -fPIC -c $(CFLAGS) konto_check.c
	gcc -shared -Wl,-soname,libkonto_check.so -o libkonto_check.so konto_check.o -lz -s

install: lib #you must be root to do this
	cp libkonto_check.so.$(LIB_VERSION) /usr/local/lib/
	ln -sf /usr/local/lib/libkonto_check.so.$(LIB_VERSION) /usr/local/lib/libkonto_check.so.$(LIB_MAJOR_VERSION)
	ln -sf /usr/local/lib/libkonto_check.so.$(LIB_VERSION) /usr/local/lib/libkonto_check.so
	ldconfig /usr/local/lib