<template>
  <UserForm create />
</template>

<script>
// @ is an alias to /src
import UserForm from '@/components/UserForm.vue';

export default {
  name: 'CreateUser',
  components: {
    UserForm,
  },
};
</script>
