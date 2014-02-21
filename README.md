### Simple IOC

#### A simple IOC container

A very simple IOC written for the fun of it...

* Constructor injection only
* No need for annotations

#### Usage

Create instance...
`IOCBuilder builder = IOCBuilder.NewInstance();`

Add bindings...
`builder.Bind<IInterface>().To<Implementation>();`

Build...
`IIOC ioc = builder.Build();`

Resolve...
`IInterface dao = ioc.Resolve<IInterface>();`