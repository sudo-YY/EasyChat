# EasyChat

本程序实现了MQTT在局域网中不同客户端互相通讯的功能。

> 优点：

1. 无需连接外网，适合车间调试工程师；
2. 没有数据库，不会存储聊天记录，不会被公司电脑监控；
3. 使用AES对称加密算法加密消息体，再也不怕抓包了，抓包的人肯定想不到我把秘钥写死在代码里了。

> 缺点：

1. 仅支持发送字符串，不能发文件、图片、表情包；
2. 当前仅支持Windows系统。

> 待办项：
1. 程序运行内存优化（已经干到200多M了）
2. 主界面样式重构
3. 优化消息处理逻辑:消息订阅使用List<String>去保存订阅的消息，也方便断线重连时的重新订阅
4. 新增分组功能，给指定人发送分组消息，被指定的人收到分组消息后可以选择订阅或退订；
5. 消息处理可以开辟新窗口界面，部分主题可能要单独处理；（如何开辟新窗口？）

