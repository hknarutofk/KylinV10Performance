package com.example.demo.main.controller;


import com.example.demo.main.service.ISbtest1Service;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.RequestMapping;

import org.springframework.web.bind.annotation.RestController;

import java.util.List;

/**
 * <p>
 *  前端控制器
 * </p>
 *
 * @author yeqiang
 * @since 2020-11-10
 */
@RestController
@RequestMapping("/main/sbtest1")
public class Sbtest1Controller {

    @Autowired
    ISbtest1Service sbtest1Service;

    @RequestMapping("values")
    public List values(){
        return sbtest1Service.list();
    }
}
