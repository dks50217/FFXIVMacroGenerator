<template>
    <div>
        <el-row :gutter="20">
            <el-select v-model="selectJob" size="small" placeholder="請選擇職業" @change="handleChange" value-key="ID">
                <el-option v-for="item in jobOptions"
                           :key="item.ID"
                           :label="item.Name"
                           :value="item">
                </el-option>
            </el-select>
        </el-row>


        <el-row :gutter="20">
            <el-tag effect="dark">技能列</el-tag>
        </el-row>

        <el-row :gutter="20" class="skillArea">
            <draggable class="list-group" v-model="actionList" :group="{ name: 'site', pull: 'clone', put: false }" animation="300" dragClass="dragClass" ghostClass="ghostClass" chosenClass="chosenClass" @start="onStart" @end="onEnd">
                <transition-group>
                    <el-avatar v-for="(item,index) in actionList" shape="square" v-bind:src="'../Image/FFXIVIcons Battle(PvE)/' + selectJob + '/' + item.ActionName" :key="index"></el-avatar>
                </transition-group>
            </draggable>
        </el-row>

        <el-divider></el-divider>

        <el-row :gutter="20">
            <el-tag type="success" effect="dark">迴圈列</el-tag>
        </el-row>

        <el-row :gutter="20" class="settingArea">
            <draggable v-model="settingList" :group="{name: 'site', put: true, pull: true}" animation="300" dragClass="dragClass" ghostClass="ghostClass" chosenClass="chosenClass" @start="onStart" @end="onEnd" @change="setMacroText">
                <transition-group class="list-group" style="border: 5px black solid;">
                    <el-avatar v-for="(item,index) in settingList" shape="square" v-bind:src="'../Image/FFXIVIcons Battle(PvE)/' + selectJob + '/' + item.ActionName" :key="index"></el-avatar>
                </transition-group>
            </draggable>
        </el-row>

        <el-divider></el-divider>

        <el-row :gutter="20">
            <el-input type="textarea"
                      placeholder=""
                      :rows="10"
                      v-model="macroText"
                      show-word-limit>
            </el-input>
        </el-row>

        <!--<el-row>
        <el-col :span="6">
            <raw-displayer :value="skillList" :title="'A'"></raw-displayer>
        </el-col>

        <el-col :span="6">
            <raw-displayer :value="settingList" :title="'B'"></raw-displayer>
        </el-col>
    </el-row>-->

    </div>
</template>

<script>
    module.exports = {
        data() {
            return {
                drag: false,
                jobOptions: [],
                actionList: [],
                settingList: [],
                dataList: null, 
                macroText: '',
                selectJob: ''
            };
        },
        methods: {
            onStart(event) {
                this.drag = true;
            },
            onEnd(event) {
                this.drag = false;
            },
            setMacroText(event) {
                let _self = this;
                let marcoStr = '';

                _self.settingList.forEach(function (element) {
                    let actionName = element.ActionName.replace('.png', '');
                    marcoStr += "/ac " + actionName + "\n";
                });

                _self.macroText = marcoStr;
            },
            handleChange(item) {
                this.settingList = [];
                this.selectJob = item.ID + '_' + item.Name;
                this.actionList = item.ActionList;
                this.macroText = '';
            }
        },
        components: {
            'draggable': window['vuedraggable'],
            'raw-displayer': httpVueLoader('../component/raw-displayer.vue')
        },
        mounted() {
            let _self = this;
            vm.getJSON('skill.json').load.then(res => _self.jobOptions = res.filter(r => r.Name));
        }
    };
</script>

<style scoped>
    .el-avatar {
        width: 50px;
        height: 50px;
        margin-left: 5px;
        cursor: grab;
    }

    .skillArea, .settingArea {
        overflow: auto;
        white-space: nowrap;
    }

    .skillArea span, .settingArea span {
        display: inline-block;
    }

    .el-row {
        margin-bottom: 20px;
    }

    .list-group {
        min-height: 50px;
        min-width: 1000px;
    }
</style>
