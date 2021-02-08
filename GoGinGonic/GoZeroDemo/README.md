# Go-Zero



```shell
go get -u github.com/tal-tech/go-zero/tools/goctl
```

-u 最新版

go build D:\AppData\goData\pkg\mod\github.com\tal-tech\go-zero@v1.1.4\tools\goctl\goctl.go

配置 goctl.exe 的环境变量



创建默认api模板

http://zero.gocn.vip/zero/bookstore.html



```text
api
├── bookstore.api                  // api定义
├── bookstore.go                   // main入口定义
├── etc
│   └── bookstore-api.yaml         // 配置文件
└── internal
    ├── config
    │   └── config.go              // 定义配置
    ├── handler
    │   ├── addhandler.go          // 实现addHandler
    │   ├── checkhandler.go        // 实现checkHandler
    │   └── routes.go              // 定义路由处理
    ├── logic
    │   ├── addlogic.go            // 实现AddLogic
    │   └── checklogic.go          // 实现CheckLogic
    ├── svc
    │   └── servicecontext.go      // 定义ServiceContext
    └── types
        └── types.go               // 定义请求、返回结构体
```