# MaxCoinTrader
App for practicing Crypto Trading. Built with C# and WPF.

## Under Development

## Notes on Architecture
(Soon this will explained in more detail.)

At the moment the system is being built with a slightly modified M-V-VM architecture.
What breaks the rules of M-V-VM is having event handling in views Code-Behind, this is done
to get the project off the ground quicker, and then refactor it - which shouldn't cause too much problems as
the rest of the architecture is followed.
